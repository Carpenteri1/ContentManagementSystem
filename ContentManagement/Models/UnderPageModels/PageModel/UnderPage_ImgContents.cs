using System;
using System.Collections.Generic;
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
    }
}
