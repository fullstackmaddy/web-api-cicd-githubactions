using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Poke.API.Facade.Dtos;
using Poke.API.Facade.Models;
using Poke.API.Facade.TypedClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Poke.API.Facade.Controllers
{
    [Route("/api/[controller]")]
    public class PokemonController : Controller
    {
        private readonly IMapper _mapper;
        private readonly PokeApiHttpClient _pokeApiHttpClient;

        public PokemonController(IMapper mapper, PokeApiHttpClient pokeApiHttpClient)
        {
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

            _pokeApiHttpClient = pokeApiHttpClient ??
                throw new ArgumentNullException(nameof(pokeApiHttpClient));

        }

        [HttpGet("{pokemonName}")]
        
        public async Task<IActionResult> GetPokemonInfoAsync(string pokemonName)
        {
            

             var pokemonInfo = await _pokeApiHttpClient
                .GetPokemonInfoAsync(pokemonName)
                .ConfigureAwait(false);

            MaskUrls(pokemonInfo);

            var pokemonInfoDto = _mapper.Map<PokemonInfoDto>(pokemonInfo);

            return Ok(pokemonInfoDto);
            
        }

        private void MaskUrls(PokemonInfo pokemonInfo)
        {
            foreach (var abilityRoot in pokemonInfo.Abilities)
            {
                int id = abilityRoot.Ability.GetAbilityId();

                abilityRoot.Ability.Url
                    = Url.Action
                    (
                        action: nameof(AbilityController.GetAbilityDescription),
                        controller: "Ability",
                        new
                        {
                            id = id
                        },
                        protocol: Url.ActionContext.HttpContext.Request.Scheme,
                        host: Url.ActionContext.HttpContext.Request.Host.ToUriComponent()
                     );

            }
            
        }
      
    }
}
