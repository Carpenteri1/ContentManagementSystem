using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;

namespace ContentManagement.Models.Content
{
    public class StartPage_TitleContent 
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }
        public string TextContent { get; set; }
        public DateTime? Edited { get; set; }

        public int UserId_FK { get; set; }
        public Users Users { get; set; }

        public int StartPageId_FK { get; set; }
        public StartPage StartPage { get; set; }
    }
}
