using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.StartPageModels;

namespace ContentManagement.Models.HeaderModels
{
    public class HeaderMenus
    {
        public int Id { get; set; }
        public ICollection<HeaderTitels> HeaderTitles { get; set; }

        public int StartPage_FK { get; set; }
        public StartPage StartPage { get; set; }
    }
}
