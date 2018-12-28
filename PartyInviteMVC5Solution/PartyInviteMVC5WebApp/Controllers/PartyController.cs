using PartyInviteMVC5WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInviteMVC5WebApp.Controllers
{
    public class PartyController : Controller
    {
        // GET: Party
        public ActionResult Index()
        {
            int hours = DateTime.Now.Hour;
            ViewBag.Greet = hours < 18 ? "Good AfterNoon " + DateTime.Now : "Good Evening" + DateTime.Now;
            return View();

        }
        //TOP MOST LAYER IS ACTION  
        public ViewResult RSVPForm()
        {
            return View();
        }
        //default is always get() method
        [HttpPost]
        public ViewResult RSVPForm(GuestResponse model)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", model);
            }
            return View();
        }//it will hold the data in the textbox and thanks view and model as a data


        public ContentResult ContentList()
        {
            var result = "<div Style='background-color:cornflower;text-align:center;color:white'><h1>This is the Content Result</h1></div>";
            return Content(result);
        }

        public JsonResult List()
        {
            var result = Json(new { Name = "Phantom", Email = "phantom@p.com", mobile = "123456789" });
            return Json(result,JsonRequestBehavior.AllowGet);
        }

        public string Greeting()
        {
            return $"Welcome to MVC5{DateTime.Now}";
        }

        
    }
}