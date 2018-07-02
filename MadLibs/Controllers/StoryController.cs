using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/funny_story")]
        public ActionResult Story()
        {
            Story myStory = new Story();
            myStory.SetName(Request.Query["name"]);
            myStory.SetCity(Request.Query["city"]);
            myStory.SetState(Request.Query["state"]);
            myStory.SetSport(Request.Query["sport"]);
            myStory.SetVerb1(Request.Query["verb1"]);
            myStory.SetVerb2(Request.Query["verb2"]);
            myStory.SetFeeling(Request.Query["feeling"]);
            myStory.SetFamily1(Request.Query["family1"]);
            myStory.SetFamily2(Request.Query["family2"]);
            myStory.SetPlace(Request.Query["place"]);
            return View(myStory);
        }

    }
}
