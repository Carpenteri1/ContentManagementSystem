
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.HeaderModel;
using ContentManagement.Models.Adverts;
using ContentManagement.UnderPageModels.PageModel;

namespace ContentManagement.StartPageModels.PageModel
{
    public class StartPage
    {
        public int Id { get; set; }
        public List<StartPage_ImgContents> StartPage_ImgContents { get; set; }
        public List<StartPage_TextContents> StartPage_TextContents { get; set; }
        public List<StartPage_TitleContents> StartPage_TitleContents { get; set; }
        public List<StartPage_Links> StartPage_Links { get; set; }
        public List<UnderPage> UnderPages { get; set; }
        public List<AdvertsModel> Adverts { get; set; }
  
    }
}
