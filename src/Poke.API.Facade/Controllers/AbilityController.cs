using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Poke.API.Facade.Dtos;
using Poke.API.Facade.TypedClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.Controllers
{
    [Route("/api/[controller]")]
    public class AbilityController : Controller
    {
        private readonly IMapper _mapper;
        private readonly PokeApiHttpClient _pokeApiHttpClient;

        public AbilityController(IMapper mapper, PokeApiHttpClient pokeApiHttpClient)
        {
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

            _pokeApiHttpClient = pokeApiHttpClient ??
                throw new ArgumentNullException(nameof(pokeApiHttpClient));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbilityDescription([FromRoute]int id)
        {
            var effectRoot = await _pokeApiHttpClient.GeEffectDetailsByAbilityIdAsync(id);

            var effectRootDto = _mapper
                .Map<EffectRootDto>(effectRoot);


            return Ok(effectRootDto);
        }
        

 
    }
}
