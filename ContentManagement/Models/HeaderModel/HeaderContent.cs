using ContentManagement.UnderPageModels.PageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ContentManagement.HeaderModel
{
    public class HeaderContent
    {
        public int Id { get; set; }
        public  string HeaderTheme { get; set; }
        public List<UnderPage> UnderPages { get; set; }


    }
}
