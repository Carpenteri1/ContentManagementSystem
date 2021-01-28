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
            .Where(item =>
            item.UserName == User.Identity.Name)
            .FirstOrDefault();

            if (grabUser != null)
            {
                editPass.UserEdited = DateTime.Now;
                TempData["User_Pass"] = editPass.Password;
                TempData["Edited"] = editPass.UserEdited;
                return Redirect("ConfirmPass");
            }
            return Redirect("UserAccount");
        }

        [Route("ConfirmPass")]
        [HttpGet]
        public ActionResult ConfirmPass()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole(UserRoles.Admin.ToString()))
                {
                    return View();
                }
                else
                {
                    TempData.Remove("Edited");
                    TempData.Remove("User_Pass");
                    return Redirect("/UserAccount");
                }

            }
            else
            {

                TempData.Remove("Edited");
                TempData.Remove("User_Pass");
                return Redirect("/Login");
            }
        }

        [Route("ConfirmPass")]
        [HttpPost]
        public ActionResult ConfirmPass(Users user)
        {
            var grabUser = context
            .Users
            .ToList()
            .Where(item =>
            item.Password == user.Password)
            .FirstOrDefault();

            if (grabUser != null)
            {
                string dateTime = TempData["Edited"].ToString();
                grabUser.Password = TempData["User_Pass"].ToString();
                grabUser.UserEdited = DateTime.Parse(dateTime);
                TempData.Remove("Edited");
                TempData.Remove("User_Pass");

                grabUser.Password = PasswordHandler.HashPassword(grabUser.Password);
                context.Update(grabUser);
                context.SaveChanges();
                return Redirect("/UserAccount");
            }
            TempData.Remove("User_Pass");
            return Redirect("/UserAccount");
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
        public ActionResult EditName(Users newName)
        {

            var grabUser = context
                .Users
                .First
                (item =>
                item.UserName == User.Identity.Name);

            if (grabUser != null)
            {
                TempData["Edited"] = DateTime.Now;
                TempData["User_NewName"] = newName.UserName;
                return Redirect("ConfirmName");

            }

                return View();
        }

        [Route("ConfirmName")]
        [HttpGet]
        public ActionResult ConfirmName()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole(UserRoles.Admin.ToString()))
                {
                    return View();
                }
                else
                {
                    TempData.Remove("Edited");
                    TempData.Remove("User_NewName");
                    return Redirect("/UserAccount");
                }

            }
            else
            {
                TempData.Remove("Edited");
                TempData.Remove("User_NewName");
                return Redirect("/Login");
            }
        }

        [Route("ConfirmName")]
        [HttpPost]
        public async Task<ActionResult> ConfirmName(Users user)
        {
            var grabUser = context
            .Users
            .ToList()
            .Where(item =>
            item.UserName == User.Identity.Name)
            .FirstOrDefault();

            if (grabUser != null)
            {
                user.UserName = TempData["User_NewName"].ToString();
                var existingClaim = claims.Find(item => item.Value == claimsKey);//find excisting user.identity using claims
                claims.Remove(existingClaim);
                claims.Add(new Claim(ClaimTypes.Name, user.UserName));//<-- adds the new username to claim
                var claimsIdentity = new ClaimsIdentity(claims, claimsKey);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                string dateTime = TempData["Edited"].ToString();
                user.UserEdited = DateTime.Parse(dateTime);

                TempData.Remove("Edited");
                TempData.Remove("User_NewName");
                context.Update(user);
                context.SaveChanges();

                return Redirect("/UserAccount");
            }
            TempData.Remove("Edited");
            TempData.Remove("User_NewName");
            return Redirect("/UserAccount");
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

            var verifyUser = context
                .Users
                .ToList()
                .Where(item =>
                item.UserName == newLogin.UserName)
                .FirstOrDefault();

            if (verifyUser != null)
            {
                if (!newLogin.UserName.Equals(verifyUser.UserName))
                {
                    return Redirect("/Login"); 
                }  
                if(!PasswordHandler.VerifyHashedPassword(verifyUser.Password,newLogin.Password))
                {
                    return Redirect("/Login");
                }
                else
                {

                    verifyUser.StartPage_ImgContents = context.StartPage_ImgContents
                        .Where(item => item.User.Id == verifyUser.Id)
                        .ToList();

                    verifyUser.StartPage_TextContents = context.StartPage_TextContents
                        .Where(item => item.User.Id == verifyUser.Id)
                        .ToList();

                    verifyUser.StartPage_Titles = context.StartPage_TitleContents
                        .Where(item => item.User.Id == verifyUser.Id)
                        .ToList();



                    if (verifyUser.UserRole.Equals(UserRoles.Admin.ToString()))
                    {
                        verifyUser.UserRole = UserRoles.Admin.ToString();
                        User.IsInRole(UserRoles.Admin.ToString());
                        claims.Add(new Claim(ClaimTypes.Role, verifyUser.UserRole));
                    }
                    else if(verifyUser.UserRole.Equals(UserRoles.User.ToString()))
                    {
                        verifyUser.UserRole = UserRoles.User.ToString();
                        User.IsInRole(UserRoles.User.ToString());
                        claims.Add(new Claim(ClaimTypes.Role, verifyUser.UserRole));
                    }
                    else
                    {
                        return Redirect("~/Login");
                    }

        
                    claims.Add(new Claim(ClaimTypes.Name, verifyUser.UserName));
                    var claimsIdentity = new ClaimsIdentity(claims, claimsKey);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    verifyUser.LastLoggedIn = DateTime.Now;
                    context.Users.Update(verifyUser);
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
        public IActionResult ConfirmRegister(Users newUser)
        {
            if (User.Identity.IsAuthenticated)
            {
                var verifyedUser = context
                    .Users
                    .First
                    (item => item.UserName == User.Identity.Name);

                if (verifyedUser != null)
                {
                    if (!PasswordHandler.VerifyHashedPassword(verifyedUser.Password, newUser.Password))
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
