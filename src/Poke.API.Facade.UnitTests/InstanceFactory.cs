using AutoMapper;
using Newtonsoft.Json;
using Poke.API.Facade.MappingProfiles;
using Poke.API.Facade.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poke.API.Facade.UnitTests
{
    public static class InstanceFactory
    {
        public static string PokemonName = "ditto";

        public static Ability Ability = new Ability
        {
            Name = "limber",
            Url = "https://pokeapi.co/api/v2/ability/7/"
        };

        public static AbilityRoot AbilityRoot = new AbilityRoot { Ability = Ability };

        public static Move Move = new Move
        {
            Name = "copy"
            
        };

        public static MoveRoot MoveRoot = new MoveRoot { Move = Move };

        public static PokemonInfo PokemonInfo = new PokemonInfo
        {
            Name = PokemonName,
            Abilities = new List<AbilityRoot> { AbilityRoot },
            Moves = new List<MoveRoot> { MoveRoot }
        };

        public static string GetJsonString(Object o)
        {
            return JsonConvert.SerializeObject(o);
        }


        public static IMapper CreateMapper()
        {
            var abilityProfile = new AbilityProfile();
            var moveProfile = new MoveProfile();
            var pokemonInfoProfile = new PokemonInfoProfile();

            var profiles = new List<Profile>
            {
                new AbilityProfile(),
                new MoveProfile(),
                new PokemonInfoProfile()
            };

            var config = new MapperConfiguration(config => config.AddProfiles(profiles));
            return config.CreateMapper();
            
        }
    }
}
