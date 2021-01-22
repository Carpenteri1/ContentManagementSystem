using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;

namespace ContentManagement.Models.StartPage
{
    public class StartPage_TextContent
    {
        [Key]
        public int Id { get; set; }

        public DateTime Created { get; set; }
        public string TextContent { get; set; }
        public DateTime? Edited { get; set; }

        public int UserId_FK { get; set; }
        public Users Users { get; set; }

        [ForeignKey("StartPage")]
        public int StartPageId_FK { get; set; }
        public StartPage StartPage { get; set; }
    }
}
