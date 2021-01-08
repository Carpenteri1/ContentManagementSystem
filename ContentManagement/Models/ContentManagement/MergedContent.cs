using ContentManagement.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.ContentManagement
{
    public class MergedContent
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TitleModel")]
        public int TitleId { get; set; }
        public TitleModel TitleModel { get; set; }


        [ForeignKey("TextContentModel")]
        public int TextContentId { get; set; }
        public TextContentModel TextContentModel { get; set; }

        [ForeignKey("ImgModel")]
        public int ImgId { get; set; }
        public ImgModel ImgModel{ get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }


        public ICollection<PageModel> MergedContents { get; set; }

    }
}
