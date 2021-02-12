using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.HeaderModel;
using ContentManagement.Models.Account;
using Microsoft.AspNetCore.Http;
using ContentManagement.StartPageModels.PageModel;

namespace ContentManagement.UnderPageModels.PageModel
{
    public class UnderPage
    {
        public int Id { get; set; }
        public string LinkTitle { get; set; }
        public DateTime? Edited { get; set; }

        public bool ShowEventModul { get; set; }
        public List<UnderPage_ImgContents> UnderPage_ImgContent { get; set; }
        public List<UnderPage_TextContents> UnderPage_TextContents { get; set; }
        public List<UnderPage_TitleContents> UnderPage_TitleContents { get; set; }
        public Users User { get; set; }
        public HeaderContent HeaderContent { get; set; }
        public StartPage StartPage { get; set; }
    }
}
