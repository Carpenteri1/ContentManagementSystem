using ContentManagement.Models.Account;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.UnderPageModels.PageModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.Adverts
{
    public class AdvertsModel
    {
        public int Id { get; set; }
        public string AdvertsTitle { get; set; }
        public DateTime Uploaded { get; set; }
        public string ImgSrc { get; set; }
        public StartPage? StartPage { get; set; }
        public UnderPage? UnderPage { get; set; }
        public DateTime? Edited { get; set; }
        public Users User { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }
    }
}
