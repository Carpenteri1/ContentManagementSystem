using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.Content
{
    public class HeaderMenu 
    {
        public int Id { get; set; }
        public ICollection<HeaderTitle> HeaderTitles { get; set; }

        public int StartPage_FK { get; set; }
        public StartPage StartPage { get; set; }
    }
}
