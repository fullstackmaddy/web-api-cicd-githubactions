using AutoMapper;
using FluentAssertions;
using Poke.API.Facade.Dtos;
using Poke.API.Facade.Models;
using Xunit;

namespace Poke.API.Facade.UnitTests.MapperProfileTests
{
    public class AbilityMappingTests
    {

        private readonly IMapper _mapper;

        public AbilityMappingTests()
        {

            _mapper = InstanceFactory.CreateMapper();
        }

        [Fact]
        public void Does_AbilityDTO_has_Expected_Mapping()
        {
            var result = _mapper
                .Map<AbilityRoot, AbilityDto>(InstanceFactory.AbilityRoot);

            //Assertions
            result.Should().BeOfType<AbilityDto>();

            var abilityDto = result as AbilityDto;

            abilityDto.Name.Should().BeEquivalentTo(InstanceFactory.Ability.Name);
            abilityDto.Url.Should().BeEquivalentTo(InstanceFactory.Ability.Url);

        }
    }
}
