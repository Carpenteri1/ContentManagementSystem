﻿using ContentManagement.Data;
using ContentManagement.HelperClasses;
using ContentManagement.Models.EventsModel;
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
            if (ModelState.IsValid)
            {
                var events = context.Events.ToList();
                var links = context.Events_Links.ToList();

                var user = context.Users.Where(item => item.UserName == User.Identity.Name).FirstOrDefault();

                foreach (var s in postedEvent.Links)
                {
                    s.EventModel = postedEvent;
                    s.User = user;
                }
                postedEvent.User = user;
                context.Add(postedEvent);
                context.SaveChanges();

                return Redirect(nameof(Index));
            }
            else
            {
                return Redirect(nameof(Index));
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

        public IActionResult Edit(EventModel eventModel)
        {
            var user = context.Users.Where(item => item.UserName == User.Identity.Name).FirstOrDefault();
            EventPageHelper helper = new EventPageHelper(context);

            if (helper.DoesAllEventsMatch(eventModel, user))
            helper.Save();


            return Redirect(nameof(Index));

        }
    }
}