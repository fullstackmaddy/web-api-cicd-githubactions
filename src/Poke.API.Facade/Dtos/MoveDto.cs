using Newtonsoft.Json;

namespace Poke.API.Facade.Dtos
{
    public class MoveDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "effect")]
        public string Effect { get; set; }

    }
}
