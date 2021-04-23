using ContentManagement.Models.EventsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ContentManagement.Models.EventsModel
{
    public class ApplicationFormModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string GolfId { get; set; }
        public string HomeClubName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        #nullable enable
        public string? GoodToknowInfo { get; set; }
        #nullable disable
        public string EventName { get; set; }

        public EventModel applyedToEvent { get; set; }
    }
}
