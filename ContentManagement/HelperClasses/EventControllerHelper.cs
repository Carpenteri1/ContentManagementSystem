using ContentManagement.Data;
using ContentManagement.Data.Services;
using ContentManagement.Models.Account;
using ContentManagement.Models.EventsModel;
using ContentManagement.Models.FilesModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private const string ToFolder = "/Upload/Images/";
        public enum eventstatus { Kommande, Passerade };
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
                if (DbEvent.TextContent != null)
                {
                    if (DbEvent.TextContent != eventItem.TextContent)
                    {
                        DbEvent.TextContent = eventItem.TextContent;
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
                        .Replace("&", "och");

                        DbEvent.EventPageRoute = eventItem.EventPageRoute;
                        
                        context.Update(DbEvent);
                        match = false;
                    }
                }
                if (eventItem.TopImage.File != null)
                {
                    FileManager manages = new FileManager(context, host);
                    DbEvent.TopImage = context.Page_ImgContents.Where(img => img.ImgSrc == manages.CopyToRootFolder(eventItem.TopImage.File, ToFolder)).FirstOrDefault();
                    if (DbEvent.TopImage == null)
                    {
                        PageImageGallery newImage = new PageImageGallery();
                        newImage.ImgSrc = manages.CopyToRootFolder(eventItem.TopImage.File, ToFolder);
                        DbEvent.TopImage = newImage;
                        context.Add(newImage);
                        context.Attach(DbEvent);
                        context.Update(DbEvent);
                        match = false;
                    }
                    else
                    {
                            context.Attach(DbEvent);
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

        public EventModel GetEventById(int id)
        {
            return context.Events.Where(item => item.Id == id).FirstOrDefault();
        } 

        public Users GetUserByName(string nameof)
        {
            return context.Users.Where(item => item.UserName == nameof).FirstOrDefault();
        }

        private List<ApplicationFormModel> GetApplicantsById(int Id)
        {
           return context
                .EventApplicants
                .Where(item => item.applyedToEvent.Id == Id)
                .ToList();
        }


        public PageImageGallery GetImgeContentById(int Id)
        {
            return context.Events.Where(page => page.Id == Id)
                .Select(item => item.TopImage).FirstOrDefault();
        }

        public bool Remove(EventModel eventModel)
        {

            eventModel.Applicants = GetApplicantsById(eventModel.Id);
            try
            {
                foreach(var applicant in eventModel.Applicants)
                {
                    context.Attach(applicant);
                    context.Remove(applicant);
                }
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
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            return true;
        }


        public bool Add(EventModel eventModel)
        {
            try
            {
                context.Add(eventModel);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public EventModel CreateNewEventData(EventModel eventModel)
        {

            if(eventModel.TopImage.File != null)
            {
                FileManager manager = new FileManager(context, host);
                var topImage = context.Page_ImgContents.Where(img => img.ImgSrc == manager.CopyToRootFolder(eventModel.TopImage.File, ToFolder)).FirstOrDefault();
                if(topImage != null)
                {
                    eventModel.TopImage = topImage;
                }
                else
                {
                    PageImageGallery eventTopImage = new PageImageGallery();
                    eventTopImage.ImgSrc = manager.CopyToRootFolder(eventModel.TopImage.File, ToFolder);
                    eventModel.TopImage = eventTopImage;
                }
                    return eventModel;
                
            }
                eventModel.TopImage = null;
                return eventModel;
        }

        public List<EventModel> GetEvents(List<EventModel> eventList,string selecterDropDownValue)
        {
            if (selecterDropDownValue == "1")
            {

                //shows passed events
                List<EventModel> passedEvents = new List<EventModel>();
                foreach (var s in eventList)
                    if (HasEventPassed(DateTime.Now, s.EventEnds))
                        passedEvents.Add(s);

                return passedEvents;
            }
            else
            {
                // shows upcoming events
                List<EventModel> upcomingEvents = new List<EventModel>();
                foreach (var s in eventList)
                    if (!HasEventPassed(DateTime.Now, s.EventEnds))
                        upcomingEvents.Add(s);


                return upcomingEvents;
            }
         
        }

        public bool HasEventPassed(DateTime now, DateTime theEvent)
        {
            return  now >= theEvent;
        }

        public SelectList CreateSelectedList(string dropdownValue)
        {
            if (dropdownValue == null)
            {
                SelectList dropdownList = new SelectList(Enum.GetValues(typeof(eventstatus)).Cast<eventstatus>().Select(v => new SelectListItem
                {
                    Text = v.ToString(),
                    Value = ((int)v).ToString(),
                }).ToList(), "Value", "Text");
                return dropdownList;
            }
            else 
            {
                SelectList dropdownList = new SelectList(Enum.GetValues(typeof(eventstatus)).Cast<eventstatus>().Select(v => new SelectListItem
                {
                    Text = v.ToString(),
                    Value = ((int)v).ToString(),
                }).ToList(), "Value", "Text", dropdownValue);
                return dropdownList;
            }
        }
    }
}
