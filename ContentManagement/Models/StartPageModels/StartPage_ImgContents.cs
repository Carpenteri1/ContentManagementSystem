using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;
using Microsoft.AspNetCore.Http;

namespace ContentManagement.Models.StartPageModels 
{
    public class StartPage_ImgContents 
    {

        public int Id { get; set; }
        public DateTime Uploaded { get; set; }
        public string ImgSrc { get; set; }
        public Users User { get; set; }
        public StartPage StartPage { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
        
    }
}
