using AutoMapper;
using Poke.API.Facade.Dtos;
using Poke.API.Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.MappingProfiles
{
    public class EffectRootProfile : Profile
    {
        public EffectRootProfile()
        {
            CreateMap<EffectRoot, EffectRootDto>();
        }
    }
}
