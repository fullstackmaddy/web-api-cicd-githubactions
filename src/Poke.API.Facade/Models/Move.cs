using Newtonsoft.Json;

namespace Poke.API.Facade.Models
{
    public class Move
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


    }

}
