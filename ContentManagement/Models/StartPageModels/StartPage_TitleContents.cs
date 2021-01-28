using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;
namespace ContentManagement.Models.StartPageModels
{
    public class StartPage_TitleContents 
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }
        public string TextContent { get; set; }
        public DateTime? Edited { get; set; }
        public Users User { get; set; }
        public StartPage StartPage { get; set; }
    }
}
