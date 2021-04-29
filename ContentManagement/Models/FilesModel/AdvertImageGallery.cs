using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.FilesModel
{
    public class AdvertImageGallery
    {
        public int Id { get; set; }
        public DateTime Uploaded { get; set; }
        public string ImgUrl { get; set;}
        public string FileName { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }

    }
}
