using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.Dtos
{
    public class PokemonInfoDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "moves")]
        public List<MoveDto> Moves { get; set; }

        [JsonProperty(PropertyName = "abilities")]
        public List<AbilityDto> Abilities { get; set; }
    }
}
