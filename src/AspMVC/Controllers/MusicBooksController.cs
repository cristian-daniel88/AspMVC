

using Microsoft.AspNetCore.Mvc;

namespace AspMVC.Controllers
{
    public class MusicBooksController : Controller
    {
        public ActionResult Detail () 
        {
        ViewBag.Books = new string[]
        {
        "clasicc",
        "history",
        "music"
        };
           return  View();
            
        }

         public string index () 
        {
            return "Hola Music index";
        }
    }
}
