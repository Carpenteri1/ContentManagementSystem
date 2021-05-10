
using ContentManagement.Models.Account;
using ContentManagement.Models.EventsModel;
using ContentManagement.Models.FilesModel;
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
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Länk rubrik: ")]
        [Required(ErrorMessage = ("Rubrik krävs"))]
        public string LinkTitle { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Länka till: ")]
        [Required(ErrorMessage = ("Måste finnas en länk"))]
        public string LinkTo { get; set; }
        [Display(Name = "Annons aktiv: ")]
        public bool isActive { get; set; }
        [Display(Name = "Välj annons typ: ")]
        public AdvertType TypeOfAdd { get; set; }

        [ForeignKey("AdvertImageGallery_FK")]
        public AdvertImageGallery AdvertImage { get; set; }
 
    }
}
