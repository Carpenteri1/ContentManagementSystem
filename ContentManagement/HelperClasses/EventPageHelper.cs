using ContentManagement.Data;
using ContentManagement.Models.Account;
using ContentManagement.Models.EventsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.HelperClasses
{
    public class EventPageHelper
    {
        private readonly CMSDbContext context;
        public EventPageHelper(CMSDbContext context)
        {
            this.context = context;
        }

        public bool DoesAllEventsMatch(EventModel eventItem, Users user)
        {
            var DbEvent = context.Events.Where(item => item.Id == eventItem.Id).FirstOrDefault();
            DbEvent.Links = context.Events_Links.Where(item => item.EventModel.Id == DbEvent.Id).ToList();

            if (!DbEvent.Equals(eventItem))
            {
                DbEvent.EventStart = eventItem.EventStart;
                DbEvent.EventEnds = eventItem.EventEnds;
                DbEvent.EventTextContent = eventItem.EventTextContent;
                DbEvent.EventTitle = eventItem.EventTitle;
                DbEvent.Links = eventItem.Links;
                DbEvent.Edited = DateTime.Now;
                DbEvent.User = user;
                context.Update(DbEvent);
                return true;
            }
            return false;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
