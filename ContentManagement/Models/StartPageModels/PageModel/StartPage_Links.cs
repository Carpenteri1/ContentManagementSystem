using ContentManagement.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.StartPageModels.PageModel
{
    public class StartPage_Links
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime? Edited { get; set; }
        public StartPage StartPage { get; set; }
        public Users User { get; set; }

     
    }
}
