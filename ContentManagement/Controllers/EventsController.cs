using ContentManagement.Data;
using ContentManagement.HelperClasses;
using ContentManagement.Models.EventsModel;
using DocuSign.eSign.Model;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using ContentManagement.Data.Services;
using ContentManagement.Models.FileModel;

namespace ContentManagement.Controllers
{
    public class EventsController : Controller
    {
        public readonly CMSDbContext context;
        private const int IncreaseByOne = 1;
        private readonly IHostingEnvironment environment;
        private readonly IWebHostEnvironment host;
        public EventsController(CMSDbContext context, IHostingEnvironment environment, IWebHostEnvironment host)
        {
            this.context = context;
            this.environment = environment;
            this.host = host;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
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
                var user = context.Users.Where(item => item.UserName == User.Identity.Name).FirstOrDefault();
                postedEvent.User = user;
                postedEvent.Created = DateTime.Now;
                postedEvent.EventPageRoute = postedEvent.EventTitle
                        .Replace("å", "a")
                        .Replace("ä", "a")
                        .Replace("ö", "o")
                        .Replace(" ", "_")
                        .Replace("!", "")
                        .Replace("?", "")
                        .Replace("–","-")
                        .Replace("&","och");
                EventControllerHelper controllerHelper = new EventControllerHelper(context);
               
                if (controllerHelper.Add(postedEvent))
                {
                    controllerHelper.SaveToDb();
                }
            }
            catch (Exception e)
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

        public IActionResult DetailedViewOfApplicants(int id, string eventId)
        {
            if (User.Identity.IsAuthenticated)
            {
                var applicants = context.EventApplicants.Where(item => item.Id == id).FirstOrDefault();
                TempData["EventId"] = eventId;
                return View(applicants);
            }
            else
            {
                return Redirect("~/login");
            }
        }


        [HttpGet]
        public ActionResult Download(string fileName)
        {

            var eventmodel = context.Events.Where(item => item.EventTitle == fileName).FirstOrDefault();
            string folder = "/TextFiles/";
            string filetype = ".txt";
            string fullPath = fileName + filetype;
            FileManager fileManager = new FileManager(context, host);

            eventmodel.Applicants = context.EventApplicants.Where(item => item.applyedToEvent.EventTitle == fileName).ToList();
            List<string> emailList = new List<string>();
            foreach (var s in eventmodel.Applicants)
                emailList.Add(s.Email);

            var file = context.FileInfo.Where(item => item.fileName == eventmodel.EventTitle).FirstOrDefault();

            if (file == null)
            {
                FileModel newFile = new FileModel();
                newFile.filePath = fileManager.CreateFileInRootFolder(fullPath, folder, emailList);
                newFile.fileName = fileName;
                newFile.fileType = filetype;
                context.Add(newFile);
                context.SaveChanges();
                file = newFile;
            }
            else
            {
                file.filePath = fileManager.CreateFileInRootFolder(fullPath, folder, emailList);
                context.Update(file);
                context.SaveChanges();
            }

            string contentRootPath = host.WebRootPath + file.filePath;
            string fullFileName = $"{file.fileName}{file.fileType}";
            byte[] bytes = System.IO.File.ReadAllBytes(contentRootPath);
            return File(bytes, "application/octet-stream", fullFileName);
        }
    }
}
