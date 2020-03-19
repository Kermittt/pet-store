using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unify.PetStore.Models;
using Unify.PetStore.Models.Enumerations;

namespace Unify.PetStore.Client
{
    /// <summary>
    /// Client service interface for accessing <see cref="Pet"/>s in the PetStore API.
    /// </summary>
    public interface IPetClient
    {
        /// <summary>
        /// Finds <see cref="Pet"/>s by <see cref="PetStatus"/>.
        /// </summary>
        /// <param name="statuses">An <see cref="IEnumerable{T}"/> containing one or more <see cref="PetStatus"/>es to filter by.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="Pet"/>.</returns>
        Task<IEnumerable<Pet>> FindByStatus(IEnumerable<PetStatus> statuses, CancellationToken cancellationToken = default);
    }
}
