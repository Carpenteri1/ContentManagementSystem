using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContentManagement.UnderPageModels.PageModel
{
    public class UnderPage_TitleContents 
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string TextContent { get; set; }
        public DateTime? Edited { get; set; }
        public UnderPage UnderPage { get; set; }
    }
}
