using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Poke.API.Facade.Dtos
{
    public class AbilityDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "effect")]
        public string Effect { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
