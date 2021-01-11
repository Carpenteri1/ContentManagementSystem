using ContentManagement.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.Content
{
    public class TitleModel
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        public string Content { get; set; }
        [DataType(DataType.Text)]
        public string TypeOfTitle { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set;}

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }

        public ICollection<MergedContent> MergedContents { get; set; }
    }
}
