using ContentManagement.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.ViewComponents
{
    public class DropDownAddsImageGallery : ViewComponent
    {
        private readonly CMSDbContext context;
        public DropDownAddsImageGallery(CMSDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var images = context.AdvertImageGallery.ToList();
            return View(images);
        }
    }
}
