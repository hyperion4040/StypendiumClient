using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StypendiumClient.Models;

namespace StypendiumClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ReSharper disable Mvc.ViewNotResolved 
            return View( ); 
            // ReSharper restore Mvc.ViewNotResolved 
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            // ReSharper disable Mvc.ViewNotResolved 
            return View( ); 
            // ReSharper restore Mvc.ViewNotResolved 
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            // ReSharper disable Mvc.ViewNotResolved 
            return View( ); 
            // ReSharper restore Mvc.ViewNotResolved 
        }

        public IActionResult Error()
        {       // ReSharper disable Mvc.ViewNotResolved 

            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
            // ReSharper restore Mvc.ViewNotResolved 
        }
        
        
        
        
    }
}