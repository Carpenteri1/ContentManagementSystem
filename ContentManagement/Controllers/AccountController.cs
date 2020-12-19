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
                LoginModel newLogin = new LoginModel();
                return View(newLogin);
            }

        }

        [Route("login")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel newLogin)
        {
            var grabUser = context
                .LoginModel
                .ToList()
                .Where(item =>
                item.UserName == newLogin.UserName &&
                item.Password == newLogin.Password).FirstOrDefault();

            if (!grabUser.Equals(null))
            {
                if (newLogin.UserName != grabUser.UserName)
                {

                }  
                if(newLogin.Password != grabUser.Password)
                {

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

                return View();

        }
    }
}
