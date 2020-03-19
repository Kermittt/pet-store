using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Models.Enumerations;
using Moq;
using Moq.Protected;
using NUnit.Framework;
using Unify.PetStore.Client;

namespace ClientTests
{
    public class PetTests
    {
        private HttpClient _httpClient;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var handlerMock = new Mock<HttpMessageHandler>();
            handlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("[{\"id\":1,\"name\":\"doggie\"}]"),
                })
                .Verifiable();

            _httpClient = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri("http://test.com/"),
            };
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _httpClient?.Dispose();
        }

        [Test]
        public async Task FindByStatus_Available_ShouldReturnResults()
        {
            // Arrange
            var petClient = new PetClient(_httpClient);
            
            // Act
            var availablePets = await petClient.FindByStatus(new[] { PetStatus.Available });

            // Assert
            availablePets.Should().NotBeEmpty("because the PetClient is expected to return some results.");
        }
    }
}