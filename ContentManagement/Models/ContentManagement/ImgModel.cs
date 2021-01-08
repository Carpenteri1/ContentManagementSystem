using ContentManagement.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.ContentManagement
{
    public class ImgModel
    {
       [Key]
       public int Id { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImgUrl { get; set; }
        public int ImgHeight { get; set; }
        public int ImgWidth { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }

        public ICollection<MergedContent> MergedContents { get; set; }

    }
}
