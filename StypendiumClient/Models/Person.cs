using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StypendiumClient.Models
{
    public class Person
    {
//        public Person(string jsoName)
//        {
//            
//            
//            JObject jObject = JObject.Parse(jsoName);
//            JToken jUser = jObject["value"];
//            Id = (int) jUser.First;
//            Name = (string) jUser.Next;
//            /*Id = (int) jUser["id"];
//            Name = (string) jUser["name"];*/
//        }
        [JsonConstructor]
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Person(string name)
        {
            Name = name;
        }

        [JsonProperty(PropertyName = "id")]
        public int Id { set; get; }
        [JsonProperty(PropertyName = "name")]
        public string Name { set; get; }
    }
}