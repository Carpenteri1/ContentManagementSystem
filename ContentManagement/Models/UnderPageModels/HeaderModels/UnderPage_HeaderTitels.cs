using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.UnderPageModels.HeaderModels
{
    public class UnderPage_HeaderTitels 
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string TextContent { get; set; }
        public DateTime? Edited { get; set; }

        public UnderPage_HeaderMenus HeaderMenu { get; set; }

    }
}
