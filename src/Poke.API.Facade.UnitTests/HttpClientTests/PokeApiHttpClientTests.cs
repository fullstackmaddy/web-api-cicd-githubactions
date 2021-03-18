using FluentAssertions;
using Moq;
using Moq.Protected;
using Poke.API.Facade.Models;
using Poke.API.Facade.TypedClients;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Poke.API.Facade.UnitTests.HttpClientTests
{
    public class PokeApiHttpClientTests
    {
        private readonly Mock<HttpMessageHandler> _mockHandler;
        private  PokeApiHttpClient _pokeApiHttpClient;

        public PokeApiHttpClientTests()
        {
            _mockHandler = new Mock<HttpMessageHandler>();

        }

        [Fact]
        public async Task Is_Pokemon_Retrieved_By_Name()
        {
            //Arrange
            MockMessageHandler(InstanceFactory.PokemonInfo);

            CreateClientInstance(_mockHandler.Object);

            //Act
            var result = await _pokeApiHttpClient.GetPokemonInfoAsync(InstanceFactory.PokemonName);

            //Assert

            result.Should().BeOfType<PokemonInfo>();

            var pokemonInfo = result as PokemonInfo;

            pokemonInfo.Name.Should().BeEquivalentTo(InstanceFactory.PokemonName);

        }


        private void MockMessageHandler(Object o)
        {
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(InstanceFactory.GetJsonString(o))
            };

            _mockHandler
                .Protected()
                .Setup<Task<HttpResponseMessage>>
                (
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(response);
        }

        private void CreateClientInstance(HttpMessageHandler messageHandler)
        {
            var httpClient = new HttpClient(messageHandler)
            {
                BaseAddress = new Uri("http://localhost/")
            };

            _pokeApiHttpClient = new PokeApiHttpClient(httpClient);
        }
    }
}
