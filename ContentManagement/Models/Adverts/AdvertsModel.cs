
using ContentManagement.Models.Account;
using ContentManagement.UnderPageModels.PageModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.Adverts
{
    public class AdvertsModel
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required]
        public string LinkTitle { get; set; }
        [DataType(DataType.Text)]
        [Required]
        public string LinkTo { get; set; }
        [Required(ErrorMessage = "Bild behövs")]
        public string ImgUrl { get; set; }

        [Display(Name = "Annons beskrivning: ")]
        public string? Description { get; set; }
        public bool isActive { get; set; }
        public Users User { get; set; }
        [Display(Name = "Välj annons typ: ")]
        public AdvertType TypeOfAdd { get; set; }
        public DateTime Uploaded { get; set; }

    }
}
