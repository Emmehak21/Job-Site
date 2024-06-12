using jobHunt.Data;
using jobHunt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace JobHunt.Controllers
{
    public class FirstController : Controller
    {
        private readonly DbContextClass dbContextClass;
        private readonly ILogger<FirstController> logger;
        public FirstController(DbContextClass dbContextClass, ILogger<FirstController> logger)
        {
            this.dbContextClass = dbContextClass;
            this.logger = logger;
        }

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
        public IActionResult resume()

        {
            return View();
        }
        [HttpGet]
        public IActionResult login(login log)

        {
            try
            {
                if (ModelState.IsValid)
                {
                    var status = dbContextClass.reg.Where(m => m.uemail == log.uemail && m.upass == log.upass).FirstOrDefault();
                    if (status == null)
                    {
                        ViewBag.status = 0;
                        ViewBag.msg = "You are not registered! create an account first.";
                    }
                    else
                    {
                        ViewBag.msg = "Login successful.";
                        return RedirectToAction("job", "First");
                    }

                }
            }
            catch (Exception ex) { }
            
            
            return View();
        }
        [HttpGet]
        public IActionResult register(Registeruser reg)

        {
            try
            {
                if (ModelState.IsValid)
                {

                    dbContextClass.Add(reg);
                    dbContextClass.SaveChanges();
                    return RedirectToAction("job", "First");


                }
            }catch (Exception ex) { }

            ViewBag.msg = 0;
            return View();
        }


    }
}
