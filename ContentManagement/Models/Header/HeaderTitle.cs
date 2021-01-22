using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;

namespace ContentManagement.Models.Header
{
    public class HeaderTitle 
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string TextContent { get; set; }
        public DateTime? Edited { get; set; }

        public int HeaderMenuId_FK { get; set; }
        public HeaderMenu HeaderMenu { get; set; }

        public int UserId_FK { get; set; }
        public Users Users { get; set; }
    }
}
