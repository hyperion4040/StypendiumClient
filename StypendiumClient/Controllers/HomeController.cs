using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StypendiumClient.Models;

namespace StypendiumClient.Controllers
{
    [Route("/api/[controller]")]
    public class HomeController : Controller
    {
        //static HttpClient client = new HttpClient();
        
        
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
        
        /*public IActionResult Start()
        {
            
            _httpClient.BaseAddress = new Uri();
            

        }*/
        
        /*static async Task RunAsync()
        {
            // New code:
            client.BaseAddress = new Uri("http://localhost:5050");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }*/
        [HttpGet]
        public string Get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5050");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/person").Result;
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;
                    return responseString;
                }
            }
            return "";
        }
        
        
        
       
    }
}