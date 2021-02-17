using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;
namespace ContentManagement.Models.EventsModel
{
    public class EventModel
    {
        public int Id { get; set; }
        public List<EventLinkModel> Links { get; set; }
        [Display(Name = "Rubrik: ")]
        [Required(ErrorMessage = "Måste ha en rubrik")]
        public string EventTitle { get; set; }
        [Display(Name = "Text: ")]
        [Required(ErrorMessage = "Måste innehålla informations text")]
        public string EventTextContent { get; set; }

        [Display(Name = "Bröd Text: ")]
        [Required(ErrorMessage = "Måste innehålla bröd text")]
        public string BodyText { get; set; }

        public Users User { get; set; }
        public DateTime? Edited { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Eventet börjar: ")]
        [Required(ErrorMessage = "Eventet måste ha ett start datum")]
        public DateTime EventStart { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Eventet slutar: ")]
        [Required(ErrorMessage = "Eventet måste ha ett slut datum")]
        public DateTime EventEnds { get; set; }
        public bool IsPrivate { get; set; }
       
        public  EventPageModel EventPageModel { get; set; }

    }
}
