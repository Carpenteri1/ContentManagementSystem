using ContentManagement.Data;
using ContentManagement.HelperClasses;
using ContentManagement.Models.EventsModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Controllers
{
    public class EventsController : Controller
    {
        public readonly CMSDbContext context;
        private const int IncreaseByOne = 1;
        public EventsController(CMSDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated) 
            {
             
                var events = context.Events.ToList();
                var applicants = context.EventApplicants.ToList();


                return View(events); 
            } 
            else
            {
                return Redirect("~/Login");
            }
       
        }

        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return Redirect("~/Login");
            }

        }

        [HttpPost]
        public IActionResult Create(EventModel postedEvent)
        {
            try
            {
                var events = context.Events.ToList();
                var links = context.Events_Links.ToList();

                var user = context.Users.Where(item => item.UserName == User.Identity.Name).FirstOrDefault();

                foreach (var s in postedEvent.Links)
                {
                    s.EventModel = postedEvent;
                    s.User = user;
                    s.EventModel = s.EventModel;
                }
                postedEvent.User = user;
                postedEvent.Created = DateTime.Now;

                context.Add(postedEvent);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return Redirect(nameof(Index));
            }
                

                return Redirect(nameof(Index));

        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var Event = context.Events.Where(item => item.Id == id).FirstOrDefault();
                var links = context.Events_Links.Where(item => item.EventModel.Id == id).ToList();
                    Event.Links = links;    


                return View(Event);
            }
            else
            {
                return Redirect("~/Login");
            }
        }

        [HttpPost]
        public IActionResult Edit(EventModel eventModel)
        {
         
            EventControllerHelper eventControllerHelper = new EventControllerHelper(context);
            var user = eventControllerHelper.GetUserByName(User.Identity.Name);

            if (!eventControllerHelper.DoesAllEventsMatch(eventModel, user))
                eventControllerHelper.SaveToDb();

            if (!eventControllerHelper.DoesAllEventsLinksMatch(eventModel, user))
                eventControllerHelper.SaveToDb();


            return RedirectToAction("Edit", new { id = eventModel.Id });

        }
        [HttpPost]
        public IActionResult Delete(EventModel eventModel)
        {
            EventControllerHelper eventHelper = new EventControllerHelper(context);
            try
            {
                if (eventHelper.Remove(eventModel))
                {
                    eventHelper.SaveToDb();
                }
                
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return Redirect(nameof(Index));
            }
            return Redirect(nameof(Index));
        }

        public IActionResult Applicants(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var applicants = context.EventApplicants.Where(item => item.applyedToEvent.Id == id).ToList();
                var theEvent = context.Events.Where(item => item.Id == id).FirstOrDefault();
                theEvent.Applicants = applicants;
                return View(theEvent);
            }
            else
            {
                return Redirect("~/login");
            }

        }
    }
}
