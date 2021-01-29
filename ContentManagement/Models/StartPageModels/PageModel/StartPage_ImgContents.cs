using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;
using ContentManagement.StartPageModels.PageModel;
using Microsoft.AspNetCore.Http;

namespace ContentManagement.StartPageModels.PageModel
{
    public class StartPage_ImgContents
    {
        [Key]
        public int Id { get; set; }
        public DateTime Uploaded { get; set; }
        public string ImgSrc { get; set; }
        
        public StartPage StartPage { get; set; }
        public Users User { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }
    }
}
