using ContentManagement.Models.Account;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.UnderPageModels.PageModel
{
    public class UnderPage_ImgContents 
    {
        public int Id { get; set; }
        public DateTime Uploaded { get; set; }
        public string ImgSrc { get; set; }
        public UnderPage UnderPage { get; set; }
        public Users User { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }

    }
}
