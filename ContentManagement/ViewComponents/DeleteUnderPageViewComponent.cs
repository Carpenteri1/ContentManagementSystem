using ContentManagement.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.ViewComponents
{
    public class DeleteUnderPageViewComponent : ViewComponent
    {
        private readonly CMSDbContext context;
        public DeleteUnderPageViewComponent(CMSDbContext context)
        {
            this.context = context;
        }

        public IViewComponentResult InvokeAsync(int Id)
        {
            var underpage = context.UnderPages.Where(item => item.Id == Id).FirstOrDefault();
            return View(underpage);
        } 
    }
}
