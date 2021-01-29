using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ContentManagement.StartPageModels.HeaderModels
{
    public class StartPage_HeaderTitels 
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string TextContent { get; set; }
        public DateTime? Edited { get; set; }

        public StartPage_HeaderMenus HeaderMenu { get; set; }

    }
}
