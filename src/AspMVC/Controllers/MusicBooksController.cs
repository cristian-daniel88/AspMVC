

using Microsoft.AspNetCore.Mvc;

namespace AspMVC.Controllers
{
    public class MusicBooksController : Controller
    {
        public ActionResult Detail () 
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday) 
            {
                return Redirect("/");
            }

            return Content("Content result ! jjaja");
            
        }

         public string index () 
        {
            return "Hola Music index";
        }
    }
}
