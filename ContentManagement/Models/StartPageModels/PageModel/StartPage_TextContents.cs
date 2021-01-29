using ContentManagement.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContentManagement.StartPageModels.PageModel
{
    public class StartPage_TextContents
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string TextContent { get; set; }
        public DateTime? Edited { get; set; }
        public StartPage StartPage { get; set; }
        public Users User { get; set; }

    }
}
