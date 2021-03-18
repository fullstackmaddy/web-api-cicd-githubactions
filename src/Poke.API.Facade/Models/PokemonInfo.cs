using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Poke.API.Facade.Models
{
    public class PokemonInfo
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "moves")]
        public List<MoveRoot> Moves { get; set; }

        [JsonProperty(PropertyName = "abilities")]
        public List<AbilityRoot> Abilities { get; set; }
    }
    

}
