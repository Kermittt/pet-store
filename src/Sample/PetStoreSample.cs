using System.Threading;
using System.Threading.Tasks;

namespace Unify.PetStore.Sample
{
    /// <summary>
    /// Service for the PetStore sample application.
    /// </summary>
    public class PetStoreSample : IPetStoreSample
    {
        /// <inheritdoc/>
        public async Task Run(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
