using ContentManagement.Models.Adverts;
using ContentManagement.Models.EventsModel;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.UnderPageModels.PageModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.FilesModel
{
    public class AdvertImageGallery
    {
        [Key]
        public int Id { get; set; }
        public string ImgSrc { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }
        public List<AdvertsModel> Adverts { get; set; }
    }
}
