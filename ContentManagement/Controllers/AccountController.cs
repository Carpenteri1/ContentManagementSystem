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

namespace ContentManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly CMSDbContext context;
        public AccountController(CMSDbContext context)
        {
            this.context = context;
        }

        [Route("Edit")]
        [HttpGet]
        public ActionResult Edit()
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



        [Route("Edit")]
        [HttpPost]
        public ActionResult Edit(Users user)
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

            if (!grabUser.Equals(null))
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
                    return Redirect("/Confirm");
                }
            }
            else
            {
                return Redirect("/Login");
            }
        }


        [Route("Confirm")]
        [HttpGet]
        public IActionResult Confirm()
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
        public IActionResult Confirm(Users user)
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
               
                    context.Users.Add(newUser);
                    context.SaveChangesAsync();
                    return Redirect("/UserAccount");
                }
                else
                {
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
