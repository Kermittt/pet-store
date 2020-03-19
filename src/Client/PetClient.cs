using Models;
using Models.Enumerations;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Unify.PetStore.Client
{
    /// <summary>
    /// Client service for accessing the PetStore API.
    /// </summary>
    public class PetClient : IPetClient
    {
        /// <inheritdoc/>
        public async Task<IEnumerable<Pet>> FindByStatus(IEnumerable<PetStatus> statuses, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
