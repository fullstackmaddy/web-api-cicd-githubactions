using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Poke.API.Facade.UnitTests.ModelTests
{
    public class AbilityTests
    {
        [Fact]
        public void Is_Correct_ID_Returned()
        {

            int id = InstanceFactory.Ability.GetAbilityId();

            //Assert
            id.Should().Be(7);




        }
    }
}
