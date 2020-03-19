using Models;
using Models.Enumerations;
using System.Collections.Generic;

namespace Unify.PetStore.Client
{
    /// <summary>
    /// Client service interface for accessing the PetStore API.
    /// </summary>
    public interface IPetClient
    {
        /// <summary>
        /// Finds <see cref="Pet"/>s by <see cref="PetStatus"/>.
        /// </summary>
        /// <param name="statuses">One or more <see cref="PetStatus"/>es to filter by.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="Pet"/>.</returns>
        IEnumerable<Pet> FindByStatus(params PetStatus[] statuses);
    }
}
