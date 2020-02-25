using Golden_Sun_2.Models;
using Golden_Sun_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Golden_Sun_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetParty()
        {

            CharacterServices cs = new CharacterServices();
            List<Character> party = cs.GetParty();
            return View("GetParty",party);
        }
        
        
    }
}