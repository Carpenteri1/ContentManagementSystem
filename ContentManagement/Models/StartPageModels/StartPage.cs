using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContentManagement.Models.StartPageModels
{
    public class StartPage
    {
        public int Id { get; set; }

        public List<StartPage_ImgContents> StartPage_ImgContents { get; set; }
        public List<StartPage_TextContents> StartPage_TextContents { get; set; }
        public List<StartPage_TitleContents> StartPage_TitleContents { get; set; }
    }
}
