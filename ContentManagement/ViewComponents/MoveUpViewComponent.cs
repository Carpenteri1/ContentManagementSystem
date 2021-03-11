using ContentManagement.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.ViewComponents
{
    public class MoveUpViewComponent : ViewComponent
    {
        private CMSDbContext context;
        public MoveUpViewComponent(CMSDbContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int Id)
        {
            var page = context.UnderPages.Where(item => item.Id == Id).FirstOrDefault();
            return View(page);
        }
    }
}
