using ContentManagement.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.EventsModel
{
    public class EventLinkModel
    {
        public int Id { get; set; }
        [Display(Name = "Länk titel.: ")]
        [Required(ErrorMessage = "Måste ha en länk title")]
        public string LinkTitle { get; set; }
        [Display(Name = "Länkar till: ")]
        [Required(ErrorMessage = "Måste länka till en sida")]
        public string Url { get; set; }
        public Users User { get; set; }
        public EventModel EventModel { get; set;}
    }
}
