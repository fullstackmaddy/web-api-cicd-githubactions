using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.Models
{
    public class Effect
    {
        [JsonProperty(PropertyName = "effect")]
        public string _Effect { get; set; }

        [JsonProperty(PropertyName = "short_effect")]
        public string ShortEffect { get; set; }

        [JsonProperty(PropertyName = "language")]
        public Language Language { get; set; }
    }
}
