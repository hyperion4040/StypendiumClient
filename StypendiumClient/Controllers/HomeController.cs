using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StypendiumClient.Models;

namespace StypendiumClient.Controllers
{
//    [Route("/api/[controller]")]
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
        
        
        //[HttpGet]
        public string Get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5050");
//                client.BaseAddress = new Uri("http://stypendium.azurewebsites.net");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("api/person/3").Result;
                
                if (response.IsSuccessStatusCode)
                {
                    string responseString = response.Content.ReadAsStringAsync().Result;
                    
                    
                    return responseString;
                }
            }

            return "";
        }

        public string metodaHelp()
        {
//            List<Person> persons = DeserializeAccounts(Get());
//            int i = persons[1].Id;
//            return i;
           /* var  person = new Person(1,"Adrian");
            var response = JsonConvert.SerializeObject(person);
            Person wynik = JsonConvert.DeserializeObject<Person>(response);*/
            var respons = Get();
            List<Person> wynik = JsonConvert.DeserializeObject<List<Person>>(respons);
            
//            var response = JsonConvert.DeserializeObject<Person>(Get());
           
            return wynik[0].Name;

        }
        public List<Person> DeserializeAccounts(string json)
        {
            return JsonConvert.DeserializeObject<List<Person>>(json);
        }
        
        public IActionResult start()
        {
            
            return View("start");
        }
        
       
    }
}