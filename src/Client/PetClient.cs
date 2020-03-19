using Models;
using Models.Enumerations;
using System.Collections.Generic;

namespace Unify.PetStore.Client
{
    /// <summary>
    /// Service for accessing the PetStore API.
    /// </summary>
    public class PetClient : IPetClient
    {
        /// <inheritdoc/>
        public IEnumerable<Pet> FindByStatus(params PetStatus[] statuses)
        {
            throw new System.NotImplementedException();
        }
    }
}
