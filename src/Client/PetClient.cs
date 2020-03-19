using System;
using Models;
using Models.Enumerations;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Unify.PetStore.Client
{
    /// <summary>
    /// Client service for accessing <see cref="Pet"/>s in the PetStore API.
    /// </summary>
    public class PetClient : IPetClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };

        public PetClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Pet>> FindByStatus(IEnumerable<PetStatus> statuses, CancellationToken cancellationToken = default)
        {
            // TODO : Once more API methods are added, much of this process should be extracted into a shared base class (e.g. request creation, error/response handling)
            try
            {
                // TODO : Url builder should be introduced to avoid issues caused by direct string manipulation (e.g. Flurl)
                var statusParam = string.Join(",", statuses.Select(s => Enum.GetName(typeof(PetStatus), s)?.ToLower()));
                var requestUri = $"pet/findByStatus?status={statusParam}";

                var request = new HttpRequestMessage(HttpMethod.Get, requestUri);

                var response = await _httpClient.SendAsync(request, cancellationToken);

                response.EnsureSuccessStatusCode();

                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    return await JsonSerializer.DeserializeAsync<IEnumerable<Pet>>(responseStream, _serializerOptions, cancellationToken);
                }
            }
            catch (Exception e)
            {
                throw new PetClientException($"Failed to call {nameof(FindByStatus)}.", e);
            }
        }
    }
}
