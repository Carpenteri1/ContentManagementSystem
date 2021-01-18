using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;

namespace ContentManagement.Models.Content
{
    public class StartPage_ImgContent 
    {
        public int Id { get; set; }
        public DateTime Uploaded { get; set; }
        public string ImgSrc { get; set; }

        public int UserId_FK { get; set; }
        public Users Users { get; set; }

        public int StartPageId_FK { get; set; }
        public StartPage StartPage { get; set; }

    }
}
