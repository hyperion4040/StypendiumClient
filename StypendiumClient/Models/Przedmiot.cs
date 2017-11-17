using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Stypendium.Models
{
    public class Przedmiot
    {
        

        [JsonConstructor]
        public Przedmiot(string nazwaPrzedmiotu, double ocena)
        {
            NazwaPrzedmiotu = nazwaPrzedmiotu;
            Ocena = ocena;
        }

        public Przedmiot()
        {
        }
        
        [JsonProperty(PropertyName = "nazwaPrzedmiotu")]
        public string NazwaPrzedmiotu { set; get; }
        [JsonProperty(PropertyName = "ocena")]
        public double Ocena { set; get; }
    }
}