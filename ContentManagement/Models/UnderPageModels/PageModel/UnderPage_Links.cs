using ContentManagement.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.UnderPageModels.PageModel
{
    public class UnderPage_Links
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime? Edited { get; set; }
        public UnderPage underPage { get; set; }
        public Users User { get; set; }
    }
}
