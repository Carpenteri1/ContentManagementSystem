using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ContentManagement.Models.Account;
using ContentManagement.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using MySqlX.XDevAPI;
using Microsoft.AspNetCore.Server.HttpSys;
using ContentManagement.Security;
using Microsoft.EntityFrameworkCore.Internal;

namespace ContentManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly CMSDbContext context;
        private const string claimsKey = "KeyOne";
        private readonly List<Claim> claims = new List<Claim>();

        public AccountController(CMSDbContext context)
        {
            this.context = context;
           
        }


        [Route("EditUser")]
        [HttpGet]
        public IActionResult EditUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole(UserRoles.Admin.ToString()))
                {
                    return View();
                }
                else
                {
                    return Redirect("/UserAccount");
                }

            }
            else
            {
                return Redirect("/Login");
            }
        }

        [Route("EditPass")]
        [HttpGet]
        public ActionResult EditPass()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole(UserRoles.Admin.ToString()))
                {
                    return View();
                }
                else
                {
                    return Redirect("/UserAccount");
                }

            }
            else
            {
                return Redirect("/Login");
            }
        }

        [Route("EditPass")]
        [HttpPost]
        public ActionResult EditPass(Users editPass)
        {

            var grabUser = context
           .Users
           .ToList()
           .Where(item => item.UserName == User.Identity.Name)
           .FirstOrDefault();

            if (grabUser != null)
            {
                if (PasswordHandler.Verify(editPass.Password, grabUser.Password))
                {
                    grabUser.Password = PasswordHandler.HashPassword(editPass.TempPassword);
                    grabUser.UserEdited = DateTime.Now;

                    context.Update(grabUser);
                    context.SaveChanges();

                    return Redirect("/UserAccount");
                }
            }
            else
            {
                ViewData["error"] = "lösenorden matcha inte";
                return Redirect("/EditPass");
            }

            return Redirect("UserAccount");
        }


        [Route("EditName")]
        [HttpGet]
        public ActionResult EditName()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole(UserRoles.Admin.ToString()))
                {
                    return View();
                }
                else
                {
                    return Redirect("/UserAccount");
                }

            }
            else
            {
                return Redirect("/Login");
            }
        }

        
        [Route("EditName")]
        [HttpPost]
        public async Task <ActionResult> EditName(Users user)
        {

            var grabUser = context
                .Users
                .Where(item => item.UserName == User.Identity.Name)
                .FirstOrDefault();

            if (grabUser != null)
            {
                if (PasswordHandler.Verify(user.Password, grabUser.Password))
                {
                    grabUser.UserName = user.UserName;
                    var existingClaim = claims.Find(item => item.Value == claimsKey);//find excisting user.identity using claims
                    claims.Remove(existingClaim);
                    claims.Add(new Claim(ClaimTypes.Name, user.UserName));//<-- adds the new username to claim
                    claims.Add(new Claim(ClaimTypes.Role, grabUser.UserRole));
                    var claimsIdentity = new ClaimsIdentity(claims, claimsKey);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    grabUser.UserEdited = DateTime.Now;
                    context.Update(grabUser);
                    context.SaveChanges();
                    ViewData["error"] = "användarnamn bytt";
                    return Redirect("/UserAccount");
                }
                else
                {
                    ViewData["error"] = "Lösenordet matchar inte";
                    return View();
                }
                
            }
            ViewData["error"] = "användarnamnet har ej bytts";
            return View();
        }

        [Route("login")]
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                    return View();
            }
            else
            {
                Users newLogin = new Users();
                return View(newLogin);
            }

        }

        [Route("login")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Users newLogin)
        {

            var dbUser = context
                .Users
                .ToList()
                .Where(item =>
                item.UserName == newLogin.UserName)
                .FirstOrDefault();

                if (dbUser != null)
            {
                if (!newLogin.UserName.Equals(dbUser.UserName))
                {
                    return Redirect("/Login"); 
                } 
                if(!PasswordHandler.Verify(newLogin.Password,dbUser.Password))
                {
                    return Redirect("/Login");
                }
                else
                {

                    if (dbUser.UserRole.Equals(UserRoles.Admin.ToString()))
                    {
                        dbUser.UserRole = UserRoles.Admin.ToString();
                        User.IsInRole(UserRoles.Admin.ToString());
                        claims.Add(new Claim(ClaimTypes.Role, dbUser.UserRole));
                    }
                    else if(dbUser.UserRole.Equals(UserRoles.User.ToString()))
                    {
                        dbUser.UserRole = UserRoles.User.ToString();
                        User.IsInRole(UserRoles.User.ToString());
                        claims.Add(new Claim(ClaimTypes.Role, dbUser.UserRole));
                    }
                    else
                    {
                        return Redirect("~/Login");
                    }

        
                    claims.Add(new Claim(ClaimTypes.Name, dbUser.UserName));
                    var claimsIdentity = new ClaimsIdentity(claims, claimsKey);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    dbUser.LastLoggedIn = DateTime.Now;
                    context.Users.Update(dbUser);
                    context.SaveChanges();
                    return Redirect("~/");
                }
            }
            else
            {
                return Redirect("/Login");
            }
        }

        [Route("Logout")]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
           await HttpContext.SignOutAsync();
           return Redirect("/Login");
            
        }


        [Route("UserAccount")]
        [HttpGet]
        public IActionResult UserAccount()
        {
            if (User.Identity.IsAuthenticated)
            {
                var model = new List<Users>();
                foreach(var s in context.Users.ToList())
                {
                    model.Add(s);
                }

                return View(model);
            }
            else
            {
                return Redirect("/Login");
            }
        }



        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole(UserRoles.Admin.ToString()))
                {
                    return View();
                }
                else
                {
                    return Redirect("/UserAccount");
                }

            }
            else
            {
                return Redirect("/Login");
            }
        }

        [Route("Register")]
        [HttpPost]
        public IActionResult Register(Users newUser)
        {
            if (User.Identity.IsAuthenticated)
            {
                var grabUser = context
               .Users
               .ToList()
               .Where(item =>
               item.UserName == newUser.UserName)
               .FirstOrDefault(); 
           
                if(grabUser == null)//<-- if the new user dont exist
                {
                    newUser.Password = PasswordHandler.HashPassword(newUser.Password);
                    TempData["NewUser_UserName"] = newUser.UserName;
                    TempData["NewUser_Pass"] = newUser.Password;
                    TempData["NewUser_ConPass"] = newUser.ConfirmPassword;
                    TempData["NewUser_Name"] = newUser.Name;
                    TempData["NewUser_Surname"] = newUser.Surname;
                    TempData["NewUser_Role"] = newUser.UserRole;

                    return Redirect("/Confirm"); 
                }
                else
                {
                    return Redirect("/UserAccount");
                }
            }
            else
            {
                return Redirect("/Login");
            }
        }


        [Route("Confirm")]
        [HttpGet]
        public IActionResult ConfirmRegister()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole(UserRoles.Admin.ToString()))
                {
                    return View();
                }
                else
                {
                    TempData.Remove("NewUser_UserName");
                    TempData.Remove("NewUser_Pass");
                    TempData.Remove("NewUser_ConPass");
                    TempData.Remove("NewUser_Name");
                    TempData.Remove("NewUser_Surname");
                    TempData.Remove("NewUser_Role");

                    return Redirect("/UserAccount");
                }
            }
            else
            {
                TempData.Remove("NewUser_UserName");
                TempData.Remove("NewUser_Pass");
                TempData.Remove("NewUser_ConPass");
                TempData.Remove("NewUser_Name");
                TempData.Remove("NewUser_Surname");
                TempData.Remove("NewUser_Role");

                return Redirect("/Login");
            }
        }

        [Route("Confirm")]
        [HttpPost]
        public IActionResult ConfirmRegister(Users confirmingUser)
        {
            if (User.Identity.IsAuthenticated)
            {
                var dbUser = context
                    .Users
                    .First
                    (item => item.UserName == User.Identity.Name);

                if (dbUser != null)
                {
                    if (!PasswordHandler.Verify(confirmingUser.Password, dbUser.Password))
                    {

                        TempData.Remove("NewUser_UserName");
                        TempData.Remove("NewUser_Pass");
                        TempData.Remove("NewUser_ConPass");
                        TempData.Remove("NewUser_Name");
                        TempData.Remove("NewUser_Surname");
                        TempData.Remove("NewUser_Role");

                        return Redirect("/UserAcount");
                    }
                    else
                    {
                        var newUser = new Users();
                        newUser.UserName = TempData["NewUser_UserName"].ToString();
                        newUser.Password = TempData["NewUser_Pass"].ToString();
                        newUser.UserCreated = DateTime.Now;
                        newUser.Name = TempData["NewUser_Name"].ToString();
                        newUser.Surname = TempData["NewUser_Surname"].ToString();
                        newUser.UserRole = TempData["NewUser_Role"].ToString();

                        TempData.Remove("NewUser_Name");
                        TempData.Remove("NewUser_Pass");
                        TempData.Remove("NewUser_ConPass");
                        TempData.Remove("NewUser_Name");
                        TempData.Remove("NewUser_Surname");
                        TempData.Remove("NewUser_Role");

                        context.Users.Add(newUser);
                        context.SaveChanges();
                        return Redirect("/UserAccount");
                    }


                }
                else
                {

                    TempData.Remove("NewUser_Name");
                    TempData.Remove("NewUser_Pass");
                    TempData.Remove("NewUser_ConPass");
                    TempData.Remove("NewUser_Name");
                    TempData.Remove("NewUser_Surname");
                    TempData.Remove("NewUser_Role");

                    return Redirect("/Register");
                }
            }
            else
            {
                return Redirect("/Login");
            }
        }

    }
}
