using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Controllers
{
    public class UnderPageController : Controller
    {
        public IActionResult Edit()
        {
            return View();
        }
    }
}
