using Newtonsoft.Json;
using Poke.API.Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Poke.API.Facade.TypedClients
{
    public class PokeApiHttpClient
    {
        private readonly HttpClient _httpClient;

        public PokeApiHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient ??
                throw new ArgumentNullException(nameof(httpClient));
        }



        public async Task<PokemonInfo> GetPokemonInfoAsync(string pokemonName)
        {
            var response = await _httpClient.GetStringAsync($"pokemon/{pokemonName}");

            return JsonConvert.DeserializeObject<PokemonInfo>(response);
            
        }

        public async Task<EffectRoot> GeEffectDetailsByAbilityIdAsync(int abilityId)
        {
            var response = await _httpClient.GetStringAsync($"ability/{abilityId}");

            var effectRoot = JsonConvert.DeserializeObject<EffectRoot>(response);

            return effectRoot;
           
        }

        public async Task<EffectRoot> GeEffectDetailsByAbilityNameAsync(int abilityName)
        {
            var response = await _httpClient.GetStringAsync($"ability/{abilityName}");

            var effectRoot = JsonConvert.DeserializeObject<EffectRoot>(response);

            return effectRoot;

        }
    }
}
