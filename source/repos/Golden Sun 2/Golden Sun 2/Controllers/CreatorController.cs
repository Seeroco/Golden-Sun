using Golden_Sun_2.Models;
using Golden_Sun_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Golden_Sun_2.Controllers
{
    public class CreatorController : Controller
    {
        // GET: Creator
        public ActionResult Index()
        {
            ViewBag.Message = "The creator page";
            CharacterServices cs = new CharacterServices();
            List<Character> characters = cs.GetAllCharacters();
            List<string> charNames = new List<string>();
            foreach (Character character in characters)
            {
                charNames.Add(character.Name);
            }
            return View("Index", charNames);
        }

        public ActionResult GetCharacter(string charName)
        {
            var cs = new CharacterServices();
            var pj = cs.GetCharacter(charName);
            return View("GetCharacter", pj);
        }
    }
}