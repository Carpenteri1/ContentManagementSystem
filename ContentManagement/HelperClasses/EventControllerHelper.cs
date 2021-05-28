using ContentManagement.Data;
using ContentManagement.Data.Services;
using ContentManagement.Models.Account;
using ContentManagement.Models.EventsModel;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment host;
        private const string ToFolder = "/Upload/EventPage/Images/";

        public EventControllerHelper(CMSDbContext context, IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
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
                if(DbEvent.IsPublic != eventItem.IsPublic)
                {
                    DbEvent.IsPublic = eventItem.IsPublic;
                    context.Update(DbEvent);
                    match = false;
                }
                if(DbEvent.applicationForm != eventItem.applicationForm)
                {
                    DbEvent.applicationForm = eventItem.applicationForm;
                    context.Update(DbEvent);
                    match = false;
                }
                if (DbEvent.EventPageRoute != null)
                {
                    if (DbEvent.EventPageRoute != eventItem.EventPageRoute)
                    {

                        eventItem.EventPageRoute = eventItem.EventTitle
                        .Replace("å", "a")
                        .Replace("ä", "a")
                        .Replace("ö", "o")
                        .Replace(" ", "_")
                        .Replace("!", "")
                        .Replace("?", "")
                        .Replace("–", "-")
                        .Replace("&", "och")
                        .Replace("Å", "A")
                        .Replace("Ä", "A")
                        .Replace("Ö", "O")
                        .Replace("è","e")
                        .Replace("È","E");


                        DbEvent.EventPageRoute = eventItem.EventPageRoute;
                        
                        context.Update(DbEvent);
                        match = false;
                    }
                }
                if (eventItem.EventImageContentModels[0].File != null)
                {
                    FileManager manages = new FileManager(context, host);
                    eventItem.EventImageContentModels[0].ImgSrc = manages.CopyToRootFolder(eventItem.EventImageContentModels[0].File, ToFolder);
                    eventItem.ImgSrc = eventItem.EventImageContentModels[0].ImgSrc;

                    if (!eventItem.ImgSrc.Equals(DbEvent.ImgSrc))
                    {
                        eventItem.EventImageContentModels[0].Uploaded = DateTime.Now;
                        DbEvent.ImgSrc = eventItem.ImgSrc;
                        var DbEventImageContent = context.EventImageContentModel.Where(item => item.EventPage.Id == eventItem.Id).FirstOrDefault();
                        DbEventImageContent.ImgSrc = eventItem.ImgSrc;
                        DbEventImageContent.Uploaded = DateTime.Now;

                        context.Attach(DbEventImageContent);
                        context.Attach(DbEvent);
                        context.Update(DbEventImageContent);
                        context.Update(DbEvent);
                        match = false;
                    }
                }
                if (DbEvent.User != null)
                {
                    if (DbEvent.User.UserName != user.UserName)
                    {
                        DbEvent.User = user;
                        context.Update(DbEvent);
                        match = false;
                    }
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
            var DbeventItem = GetEventById(eventItem.Id);

            if (DbeventItem != null)//if they dont match, save new content
            { 
                if(DbeventItem.LinkTitle != eventItem.LinkTitle)
                {
                    DbeventItem.LinkTitle = eventItem.LinkTitle;
                    context.Update(DbeventItem);
                    match = false;
                }
                if(DbeventItem.User != null)
                {
                    if(DbeventItem.User.UserName != user.UserName)
                    {
                        DbeventItem.User = user;
                        context.Update(DbeventItem);
                        match = false;
                    }
                }
            }

                return match;
        }

        private EventModel GetEventById(int id)
        {
            return context.Events.Where(item => item.Id == id).FirstOrDefault();
        } 

        public Users GetUserByName(string nameof)
        {
            return context.Users.Where(item => item.UserName == nameof).FirstOrDefault();
        }

        public bool Remove(EventModel eventModel)
        {
            eventModel.Applicants = context.EventApplicants.Where(item => item.applyedToEvent.Id == eventModel.Id).ToList();
            var eventModelImageContent = context.EventImageContentModel.Where(item => item.EventPage.Id == eventModel.Id).FirstOrDefault();
            try
            {
                foreach(var applicant in eventModel.Applicants)
                {
                    context.Attach(applicant);
                    context.Remove(applicant);
                }
                context.Attach(eventModelImageContent);
                context.Attach(eventModel);
                context.Remove(eventModelImageContent);
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


        public bool Add(EventModel eventModel)
        {
            try
            {
                context.Add(eventModel);
                context.Add(eventModel.EventImageContentModels[0]);
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public EventModel CreateNewEventData(EventModel eventModel)
        {

            if(eventModel.EventImageContentModels[0].File != null)
            {
                FileManager mangager = new FileManager(context, host);
                eventModel.EventImageContentModels[0].ImgSrc = mangager.CopyToRootFolder(eventModel.EventImageContentModels[0].File, ToFolder);
            }
            else
            {
                eventModel.EventImageContentModels[0].ImgSrc = "\"\"";
            }
            try
            {
               
                eventModel.ImgSrc = eventModel.EventImageContentModels[0].ImgSrc;
                eventModel.EventImageContentModels[0].Uploaded = DateTime.Now;
                eventModel.EventImageContentModels[0].EventPage = eventModel;
            }
            catch
            {
                return eventModel;
            }
            return eventModel;
        }
    }
}
