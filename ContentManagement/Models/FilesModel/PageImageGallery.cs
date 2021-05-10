using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ContentManagement.UnderPageModels.PageModel;
using System.Threading.Tasks;
using ContentManagement.Models.Account;
using System.ComponentModel.DataAnnotations;
using ContentManagement.Models.EventsModel;

namespace ContentManagement.Models.FilesModel
{
    public class PageImageGallery
    {
        [Key]
        public int Id { get; set; }
        public string ImgSrc { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }
        /*
#nullable enable
        [ForeignKey("UnderPage_FK")]
        public virtual UnderPage? UnderPage { get; set; }

        [ForeignKey("EventPage_FK")]
        public virtual EventModel? EventPage { get; set; }
#nullable disable
        */
    }
}
