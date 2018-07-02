using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
    public class StoryController : Controller
    {
        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/story")]
        public ActionResult Story()
        {
            return View();
        }

    }
}
