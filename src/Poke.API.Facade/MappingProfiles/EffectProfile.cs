using AutoMapper;
using Poke.API.Facade.Dtos;
using Poke.API.Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.MappingProfiles
{
    public class EffectProfile : Profile
    {
        public EffectProfile()
        {
            CreateMap<Effect, EffectDto>()
                .ForMember(nameof(EffectDto.Description),
                dest => dest.MapFrom(src => src._Effect))
                .ForMember(nameof(EffectDto.ShortDescription),
                dest => dest.MapFrom(src => src.ShortEffect));

        }

    }
}
