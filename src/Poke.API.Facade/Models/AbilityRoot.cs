using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.Models
{
    public class AbilityRoot
    {
        [JsonProperty(PropertyName = "ability")]
        public Ability Ability { get; set; }
    }
}
