using System.Threading;
using System.Threading.Tasks;

namespace Unify.PetStore.Sample
{
    /// <summary>
    /// Service interface for the PetStore sample application.
    /// </summary>
    public interface IPetStoreSample
    {
        /// <summary>
        /// Executes the PetStore sample application.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
        Task Run(CancellationToken cancellationToken = default);
    }
}
