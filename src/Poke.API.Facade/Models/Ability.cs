using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Poke.API.Facade.Models
{

    public class Ability
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "language")]
        public Language Language { get; set; }


        public int GetAbilityId()
        {
            
            var index = this.Url.LastIndexOf("/");

            var idSubstring = this.Url.Substring(index - 1, 1);

            return Convert.ToInt32(idSubstring);

           
        }
    }
}
