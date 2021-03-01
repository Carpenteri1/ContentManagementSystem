using ContentManagement.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.ViewComponents
{
    public class DeleteEventViewComponent : ViewComponent
    {
        private readonly CMSDbContext context;
        public DeleteEventViewComponent(CMSDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int Id)
        {
            var eventData = context.Events.Where(item => item.Id == Id).FirstOrDefault();
            return View(eventData);
        }
    }
}
