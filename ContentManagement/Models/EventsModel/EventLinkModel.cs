using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.EventsModel
{
    public class EventLinkModel
    {
        public int Id { get; set; }
        public string LinkTitle { get; set; }
        public string Url { get; set; }
        public EventModel EventModel { get; set;}
    }
}
