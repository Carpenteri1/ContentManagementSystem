using ContentManagement.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Controllers
{
    public class EventsController : Controller
    {
        public readonly CMSDbContext context;
        public EventsController(CMSDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated) 
            {
                var events = context.Events.ToList();
                var links = context.Events_Links.ToList();
                foreach(var s in events)
                {
                    for(int i = 0; i < links.Count(); i++)
                    {
                        if (s.Id == links[i].EventModel.Id)
                        {
                            s.Links.Add(links[i]); 
                        }
                    }
              
                }

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
    }
}
