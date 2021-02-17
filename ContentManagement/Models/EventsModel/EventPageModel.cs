using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.EventsModel
{
    public class EventPageModel
    {
        public int Id { get; set; }
        public List<EventModel> EventModel { get; set; }
    }
}
