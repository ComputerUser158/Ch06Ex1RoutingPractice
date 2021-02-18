using Microsoft.AspNetCore.Mvc;


namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display(string id)
        {
            if (id == null)
            {
                return Content("No ID supplied.");
            }
            else
            {
                return Content("ID: " + id);
            }
        }
        [Route("[action]/{start}/{end?}/{message?}")]
        public IActionResult Countdown(int start, int end = 0, string message = "")
        {
            string contentString = "Counting down:\n";
            for (int i = start; i >= end; i--)
            {
                contentString += i + "\n";
            }
            return Content(contentString + message);
        }
    }
    public class DummyPage1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public class DummyPage2 : Controller  // anytime I tried to add routing the sites would break and I didn't know how to fix it
    {
        public IActionResult Index()  // therfore I assumed having working dummy pages was more important than having everything broken.
        {
            return View();  // which is why these do whatever routing they need to. I also don't know how admin works, at all.
        }
    }
    public class DummyPage3 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
