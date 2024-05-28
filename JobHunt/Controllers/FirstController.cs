using Microsoft.AspNetCore.Mvc;

namespace JobHunt.Controllers
{
    public class FirstController : Controller
    {
      
        public IActionResult home()
        {
            return View();
        }


    }
}
