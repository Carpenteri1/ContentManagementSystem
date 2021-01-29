using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContentManagement.UnderPageModels.PageModel
{
    public class UnderPage
    {
        public int Id { get; set; }
        public List<UnderPage_ImgContents> UnderPage_ImgContents { get; set; }
        public List<UnderPage_TextContents> UnderPage_TextContents { get; set; }
        public List<UnderPage_TitleContents> UnderPage_TitleContents { get; set; }
        public List<UnderPage_Links> UnderPage_Links { get; set; }
    }
}
