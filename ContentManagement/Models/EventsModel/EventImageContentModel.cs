using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.EventsModel
{
    public class EventImageContentModel
    {
        public int Id { get; set; }
        public DateTime Uploaded { get; set; }
        public string ImgSrc { get; set; }
        public EventModel EventPage { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }

    }
}
