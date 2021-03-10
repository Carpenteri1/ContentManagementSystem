using ContentManagement.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.ViewComponents
{
    public class DeleteAdvertViewComponent : ViewComponent
    {
        private readonly CMSDbContext context;
        public DeleteAdvertViewComponent(CMSDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int Id)
        {
            var advertData = context.Adverts.Where(item => item.Id == Id).FirstOrDefault();
            return View(advertData);
        }
    }
}
