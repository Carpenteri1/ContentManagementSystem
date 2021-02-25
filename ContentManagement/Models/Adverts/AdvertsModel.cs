
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
        [Display(Name = "Länk rubrik: ")]
        [Required(ErrorMessage = ("Rubrik krävs"))]
        public string LinkTitle { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Länka till: ")]
        [Required(ErrorMessage = ("Måste finnas en länk"))]
        public string LinkTo { get; set; }
        public string ImgUrl { get; set; }

        [Display(Name = "Annons beskrivning: ")]
        public string? Description { get; set; }
        [Display(Name = "Annons aktiv: ")]
        public bool isActive { get; set; }
        public Users User { get; set; }
        [Display(Name = "Välj annons typ: ")]
        public AdvertType TypeOfAdd { get; set; }
        public DateTime Uploaded { get; set; }
        [NotMapped]
        [Display(Name = "Annons bild")]
        [Required(ErrorMessage = ("Måste finnas en bild"))]
        public IFormFile? File { get; set; }

    }
}
