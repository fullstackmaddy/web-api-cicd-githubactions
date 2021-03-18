using AutoMapper;
using Poke.API.Facade.Dtos;
using Poke.API.Facade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.API.Facade.MappingProfiles
{
    public class MoveProfile : Profile
    {
        public MoveProfile()
        {
            CreateMap<MoveRoot, MoveDto>()
                .ForMember(nameof(MoveDto.Name), dest => dest.MapFrom(src => src.Move.Name));
                
        }
    }
}
