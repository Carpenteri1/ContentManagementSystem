using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;

namespace ContentManagement.Models.Content
{
    public class StartPage 
    {
        public int Id { get; set; }
   
        public ICollection<StartPage_ImgContent> StartPage_ImgContents { get; set; }
        public ICollection<StartPage_TextContent> StartPage_TextContents { get; set; }
        public ICollection<StartPage_TitleContent> StartPage_TitleContents { get; set; }

    }
}
