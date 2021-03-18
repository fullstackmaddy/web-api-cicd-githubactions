using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.Models
{
    public class EffectRoot
    {

        [JsonProperty(PropertyName = "effect_entries")]
        public List<Effect> Effects { get; set; }
    }
}
