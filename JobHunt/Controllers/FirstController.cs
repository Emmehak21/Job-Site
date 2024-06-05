using Microsoft.AspNetCore.Mvc;

namespace JobHunt.Controllers
{
    public class FirstController : Controller
    {
      
        public IActionResult home()

        {
            ViewData["Title"] = "Home";
            ViewBag.Quote = "Your Dream Job Awaits!";
            TempData["Quote2"] = "Discover thousands of job opportunities tailored to your skills and ambitions.\r\nJoin now to find the perfect match and take the next step in your career journey.";
            TempData.Keep();
            return View();
        }

        public IActionResult job()

        {
            ViewData["Title"] = "Find jobs";
            return View();
        }
        public IActionResult Candidates()

        {
            ViewData["Title"] = "Find Candidates";
            return View();
        }
        public IActionResult blog()

        {
            ViewData["Title"] = "Blog";
            return View();
        }
        public IActionResult ContactUs()

        {
            ViewData["Title"] = "Contact Us";
            return View();
        }


    }
}
