using ContentManagement.Data;
using ContentManagement.Models.Account;
using ContentManagement.Models.EventsModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.HelperClasses
{
    public class EventControllerHelper
    {
        private readonly CMSDbContext context;
        public EventControllerHelper(CMSDbContext context)
        {
            this.context = context;
        }

        public bool DoesAllEventsMatch(EventModel eventItem, Users user)
        {
            var DbEvent = GetEventById(eventItem.Id);
            bool match = true;

            if (DbEvent != null)//if they dont match, save new content
            {
                if (DbEvent.EventTitle != null)
                {
                    if (DbEvent.EventTitle != eventItem.EventTitle)
                    {
                        DbEvent.EventTitle = eventItem.EventTitle;
                        context.Update(DbEvent);
                        match = false;
                    }
                }
                if (DbEvent.EventTextContent != null)
                {
                    if (DbEvent.EventTextContent != eventItem.EventTextContent)
                    {
                        DbEvent.EventTextContent = eventItem.EventTextContent;
                        context.Update(DbEvent);
                        match = false;
                    }
                }
                if (DbEvent.BodyText != null)
                {
                    if (DbEvent.BodyText != eventItem.BodyText)
                    {
                        DbEvent.BodyText = eventItem.BodyText;
                        context.Update(DbEvent);
                        match = false;
                    }
                }
                if (DbEvent.EventEnds != null)
                {
                    if (DbEvent.EventEnds != eventItem.EventEnds)
                    {
                        DbEvent.EventEnds = eventItem.EventEnds;
                        context.Update(DbEvent);
                        match = false;
                    }
                }
                if (DbEvent.EventStart != null)
                {
                    if (DbEvent.EventStart != eventItem.EventStart)
                    {
                        DbEvent.EventStart = eventItem.EventStart;
                        context.Update(DbEvent);
                        match = false;
                    }
                }
                if(DbEvent.IsPrivate != eventItem.IsPrivate)
                {
                    DbEvent.IsPrivate = eventItem.IsPrivate;
                    context.Update(DbEvent);
                    match = false;
                }
                if (!match)
                {
                    DbEvent.Edited = DateTime.Now;
                    context.Update(DbEvent);
                }

            }
            return match;
        }

        public bool DoesAllEventsLinksMatch(EventModel eventItem, Users user)
        {
            bool match = true;
            var DbeventItem = GetModelLinkById(eventItem.Id);

            if (DbeventItem != null)//if they dont match, save new content
            { 
                if(DbeventItem.LinkTitle != eventItem.Links[0].LinkTitle)
                {
                    DbeventItem.LinkTitle = eventItem.Links[0].LinkTitle;
                    context.Update(DbeventItem);
                    match = false;
                }
                if(DbeventItem.Url != eventItem.Links[0].Url)
                {
                    DbeventItem.Url = eventItem.Links[0].Url;
                    context.Update(DbeventItem);
                    match = false;
                }
            }

                return match;
        }

        private EventModel GetEventById(int id)
        {
            return context.Events.Where(item => item.Id == id).FirstOrDefault();
        } 

        private EventLinkModel GetModelLinkById(int id)
        {
            return context.Events_Links.Where(item => item.EventModel.Id == id).FirstOrDefault();
        }

        public Users GetUserByName(string nameof)
        {
            return context.Users.Where(item => item.UserName == nameof).FirstOrDefault();
        }

        public bool Remove(EventModel eventModel)
        {
            eventModel.Links = context.Events_Links.Where(item => item.EventModel.Id == eventModel.Id).ToList();

            try
            {
                context.Attach(eventModel);
                context.Attach(eventModel.Links[0]);
                context.Remove(eventModel.Links[0]);
                context.Remove(eventModel);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public bool SaveToDb()
        {
            try
            {
                context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
