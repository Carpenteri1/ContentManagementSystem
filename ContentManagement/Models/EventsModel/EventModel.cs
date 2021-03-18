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
        public string EventTitle { get; set; }
        public string EventTextContent { get; set; }
        public string BodyText { get; set; }

        public Users User { get; set; }
        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        public DateTime? Edited { get; set; }
        [DataType(DataType.Date)]
        public DateTime EventStart { get; set; }
        [DataType(DataType.Date)]
        public DateTime EventEnds { get; set; }
        public bool IsPublic { get; set; }

    }
}
