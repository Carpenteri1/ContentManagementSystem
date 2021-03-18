using ContentManagement.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.ViewComponents
{
    public class PageImageGalleryViewComponent : ViewComponent
    {
        private readonly CMSDbContext context;
        public PageImageGalleryViewComponent(CMSDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var images = context.PagesImageGallery.ToList();
            return View(images);
        }
    }
}
