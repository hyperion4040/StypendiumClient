﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Stypendium.Models;
using StypendiumClient.Models;

namespace StypendiumClient.Controllers
{
    public class KierunekController : Controller
    {
        private string url = "http://localhost:5050";
        
        // GET
        public IActionResult Index()
        {
            //IEnumerable<Person> data = null;
           
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri
                        ("http://localhost:5050");
                    MediaTypeWithQualityHeaderValue contentType = 
                        new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    HttpResponseMessage response = client.GetAsync
                        ("/api/person").Result;
                    string stringData = response.Content.
                        ReadAsStringAsync().Result;
                    IEnumerable<Person> data = JsonConvert.DeserializeObject
                        <IEnumerable<Person>>(stringData);
                    return View(data);
                }
                    
                
                // ReSharper disable Mvc.ViewNotResolved 
               /* return View(data);*/
                // ReSharper restore Mvc.ViewNotResolved 
            }
            
           
        
           
            
        

       /* private ActionResult Przedmioty(string url)
        {
            
           
            
               
          


        }*/

       /* public string getPrzedmiot(int index)
        {
            var response = Przedmioty(url);
           // List<Przedmiot> kierunek = JsonConvert.DeserializeObject<List<Przedmiot>>(response);
            WielePrzedmiot wielePrzedmiot = JsonConvert.DeserializeObject<WielePrzedmiot>(response); 
            //return kierunek[index].NazwaPrzedmiotu;
            return wielePrzedmiot.przedmioty[index].NazwaPrzedmiotu;
        }*/
        
       /* public string getNowyPrzedmiot()
        {
            var response = Przedmioty(url);
            List<Przedmiot> przedmiots = JsonConvert.DeserializeObject<List<Przedmiot>>(response);
            return przedmiots[0].NazwaPrzedmiotu;
        }*/

        /*private void putOcena(string przedmiot, double ocena)
        {
            using (var client = new HttpClient())
            {
                Przedmiot p = new Przedmiot(przedmiot,ocena);
                client.BaseAddress = new Uri(url);
                var response = client.PutAsJsonAsync("/api/przedmiot", p).Result;
            }
        }*/
        /*[HttpPost]
        public IActionResult putOceny(Przedmiot przedmiot)
        {
            putOcena(przedmiot.NazwaPrzedmiotu,przedmiot.Ocena);
            return View("Przedmioty");
        }*/
        
    }
}