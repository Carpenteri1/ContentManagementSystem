using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.Content
{
    public class PageModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MergedContent")]
        public int MergedContentId { get; set; }
        public MergedContent MergedContent { get; set; }

    }
}
