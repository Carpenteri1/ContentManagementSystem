using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ContentManagement.Models.Account;
using System.Security.Claims;
using ContentManagement.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using MySqlX.XDevAPI;

namespace ContentManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly CMSDbContext context;
        public AccountController(CMSDbContext context)
        {
            this.context = context;
        }

        [Route("EditPass")]
        [HttpGet]
        public ActionResult EditPass()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
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
            item.UserName == User.Identity.Name).FirstOrDefault();
            if (grabUser != null)
            {

                TempData["User_Pass"] = editPass.Password;
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
                return View();
            }
            else
            {
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
                grabUser.Password = TempData["User_Pass"].ToString();
                TempData.Remove("User_Pass");
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
                return View();
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
                .ToList()
                .Where(item =>
                item.UserName == User.Identity.Name).FirstOrDefault();

            if (grabUser != null)
            {

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
                return View();
            }
            else
            {
                return Redirect("/Login");
            }
        }

        [Route("ConfirmName")]
        [HttpPost]
        public ActionResult ConfirmName(Users user)
        {
            var grabUser = context
            .Users
            .ToList()
            .Where(item =>
            item.Password == user.Password)
            .FirstOrDefault();

            if (grabUser != null)
            {
                grabUser.UserName = TempData["User_NewName"].ToString();
                TempData.Remove("User_NewName");
                context.Update(grabUser);
                context.SaveChanges();
                return Redirect("/UserAccount");
            }
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
            var grabUser = context
                .Users
                .ToList()
                .Where(item =>
                item.UserName == newLogin.UserName &&
                item.Password == newLogin.Password).FirstOrDefault();

            if (grabUser != null)
            {
                if (newLogin.UserName != grabUser.UserName)
                {
                    //TODO Message text
                }  
                if(newLogin.Password != grabUser.Password)
                {
                    //TODO Message text
                }
                else
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, newLogin.UserName)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, "Login");

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return Redirect("~/");
                }
            }
            else
            {
                return Redirect("/Login");
            }

            return Redirect("/Login");
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
                return View();
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
                return View();
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
           
                if(grabUser != null)
                {
                    return Redirect("/Register"); 
                }
                else
                {
                    
                    TempData["NewUser_Name"] = newUser.UserName;
                    TempData["NewUser_Pass"] = newUser.Password;
                    TempData["NewUser_ConPass"] = newUser.ConfirmPassword;


                    return Redirect("/ConfirmRegister");
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
                return View();
            }
            else
            {
                return Redirect("/Login");
            }
        }

        [Route("Confirm")]
        [HttpPost]
        public IActionResult ConfirmRegister(Users user)
        {
            if (User.Identity.IsAuthenticated)
            {
                
              var grabUser = context
              .Users
              .ToList()
              .Where(item =>
              item.Password == user.Password)
              .FirstOrDefault();

                if (grabUser != null)
                {
                    var newUser = new Users
                    {
                        UserName = TempData["NewUser_Name"].ToString(),
                        Password = TempData["NewUser_Pass"].ToString(),
                        ConfirmPassword = TempData["NewUser_ConPass"].ToString()
                    };

                    TempData.Remove("NewUser_Name");
                    TempData.Remove("NewUser_Pass");
                    TempData.Remove("NewUser_ConPass");

                    context.Users.Add(newUser);
                    context.SaveChangesAsync();
                    return Redirect("/UserAccount");
                }
                else
                {
                    TempData.Remove("NewUser_Name");
                    TempData.Remove("NewUser_Pass");
                    TempData.Remove("NewUser_ConPass");

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
