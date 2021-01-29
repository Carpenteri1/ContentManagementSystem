using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.StartPageModels.PageModel;

namespace ContentManagement.StartPageModels.HeaderModels
{
    public class StartPage_HeaderMenus
    {
        public int Id { get; set; }
        public List<StartPage_HeaderTitels> HeaderTitles { get; set; }

        public StartPage StartPage { get; set; }
    }
}
