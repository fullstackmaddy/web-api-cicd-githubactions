using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.Models
{
    public class MoveRoot
    {
        [JsonProperty(PropertyName = "move")]
        public Move Move { get; set; }
    }
}
