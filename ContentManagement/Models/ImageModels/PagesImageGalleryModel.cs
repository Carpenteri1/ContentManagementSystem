using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.ImageModels
{
    public class PagesImageGalleryModel
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }
    }
}
