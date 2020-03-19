using System;
using Microsoft.Extensions.DependencyInjection;

namespace Unify.PetStore.Client
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IPetClient"/> service to the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the <see cref="IPetClient"/> to.</param>
        /// <param name="baseAddress">The base address for the PetStore service.</param>
        /// <returns>An <see cref="IHttpClientBuilder"/> that can be used to configure the client.</returns>
        public static IHttpClientBuilder AddPetHttpClient(this IServiceCollection services, string baseAddress)
        {
            return services.AddHttpClient<IPetClient, PetClient>()
                .ConfigureHttpClient(configureClient =>
                    configureClient.BaseAddress = new Uri(baseAddress, UriKind.Absolute)
                );
        }
    }
}
