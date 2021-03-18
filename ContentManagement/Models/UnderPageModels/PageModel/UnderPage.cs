﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.HeaderModel;
using ContentManagement.Models.Account;
using Microsoft.AspNetCore.Http;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.Models.Adverts;
namespace ContentManagement.UnderPageModels.PageModel
{
    public class UnderPage
    {
        public int Id { get; set; }
        public string LinkTitle { get; set; }
        public DateTime? Edited { get; set; }
        public bool IsPublic { get; set; }
        public bool ShowEventModul { get; set; }
        public bool ShowFormModul { get; set; }
        public int OrderPosition { get; set; }
        public bool ShowEmailFormModul { get; set; }
        public string underPageImgSource { get; set; }
        public string TextContent { get; set; }
        public string PageTitle { get; set; }
        public Users User { get; set; }
        public HeaderContent HeaderContent { get; set; }
        public StartPage StartPage { get; set; }
        public string pageRoute { get; set; }   
        public int AmmountOfAdverts { get; set; }
    }
}
