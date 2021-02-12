using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.Adverts
{
    public class AdvertType
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Reklam typ")]
        [Required(ErrorMessage = ("Reklam typ krävs"))]
        public string TypeOfAd { get;set; }
        public List<AdvertsModel> AdvertsModel { get; set; }
    }
}
