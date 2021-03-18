using AutoMapper;
using FluentAssertions;
using Poke.API.Facade.Dtos;
using Poke.API.Facade.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Poke.API.Facade.UnitTests.MapperProfileTests
{
    public class PokemonInfoMappingTests
    {
        private readonly IMapper _mapper;

        public PokemonInfoMappingTests()
        {
            _mapper = InstanceFactory.CreateMapper();
        }


        [Fact]
        public void Does_PokemonInfo_Has_Correct_Mapping()
        {
            var result = _mapper
                .Map<PokemonInfo, PokemonInfoDto>(InstanceFactory.PokemonInfo);

            result.Should().BeOfType<PokemonInfoDto>();

            var pokemonInfoDto = result as PokemonInfoDto;

            pokemonInfoDto.Name.Should().BeEquivalentTo(InstanceFactory.PokemonInfo.Name);

            pokemonInfoDto.Abilities.Count.Should().Be(1);
            pokemonInfoDto.Abilities[0].Name.Should().BeEquivalentTo(InstanceFactory.PokemonInfo.Abilities[0].Ability.Name);
            pokemonInfoDto.Abilities[0].Url.Should().BeEquivalentTo(InstanceFactory.PokemonInfo.Abilities[0].Ability.Url);
            

            pokemonInfoDto.Moves.Count.Should().Be(1);
            pokemonInfoDto.Moves[0].Name.Should().BeEquivalentTo(InstanceFactory.PokemonInfo.Moves[0].Move.Name);
            
            



        }
    }
}
