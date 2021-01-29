using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.UnderPageModels.PageModel;

namespace ContentManagement.UnderPageModels.HeaderModels
{
    public class UnderPage_HeaderMenus
    {
        public int Id { get; set; }
        public List<UnderPage_HeaderTitels> HeaderTitles { get; set; }

        public UnderPage UnderPage { get; set; }
    }
}
