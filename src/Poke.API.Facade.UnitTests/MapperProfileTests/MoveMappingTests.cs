using AutoMapper;
using Poke.API.Facade.Dtos;
using Poke.API.Facade.Models;
using FluentAssertions;
using Xunit;

namespace Poke.API.Facade.UnitTests.MapperProfileTests
{
    public class MoveMappingTests
    {
        private readonly IMapper _mapper;

        public MoveMappingTests()
        {

            _mapper = InstanceFactory.CreateMapper();
        }

        [Fact]
        public void Does_MoveDto_Has_Expected_Mapping()
        {
            var result = _mapper
                .Map<MoveRoot, MoveDto>(InstanceFactory.MoveRoot);

            //Assertions

            result.Should().BeOfType<MoveDto>();

            var moveDto = result as MoveDto;

            moveDto.Name.Should().BeEquivalentTo(InstanceFactory.Move.Name);
            
            
        }

        
    }
}
