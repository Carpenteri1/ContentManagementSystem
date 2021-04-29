using ContentManagement.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ContentManagement.UnderPageModels.PageModel
{
    public class UnderPage_TextContents 
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Edited { get; set; }

        public UnderPage UnderPage { get; set; }

        public Users User { get; set; }
    }
}
