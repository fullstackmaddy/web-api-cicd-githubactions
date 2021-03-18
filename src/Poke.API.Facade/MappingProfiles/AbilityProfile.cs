using AutoMapper;
using Poke.API.Facade.Dtos;
using Poke.API.Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.MappingProfiles
{
    public class AbilityProfile : Profile
    {
        public AbilityProfile()
        {
            CreateMap<AbilityRoot, AbilityDto>()
                .ForMember(nameof(AbilityDto.Name), dest => dest.MapFrom(src => src.Ability.Name))
                .ForMember(nameof(AbilityDto.Url), dest => dest.MapFrom(src => src.Ability.Url));

        }
    }
}
