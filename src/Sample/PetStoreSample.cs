using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Unify.PetStore.Client;
using Unify.PetStore.Models.Enumerations;

namespace Unify.PetStore.Sample
{
    /// <summary>
    /// Service for the PetStore sample application.
    /// </summary>
    public class PetStoreSample : IPetStoreSample
    {
        private readonly IPetClient _petClient;

        public PetStoreSample(IPetClient petClient)
        {
            _petClient = petClient;
        }

        /// <inheritdoc/>
        public async Task Run(CancellationToken cancellationToken = default)
        {
            var availablePets = await _petClient.FindByStatus(new[] { PetStatus.Available }, cancellationToken);
            var sortedPets = availablePets.OrderByDescending(p => p.Name)
                .GroupBy(p => p.Category != null && !string.IsNullOrWhiteSpace(p.Category.Name) ? p.Category.Name : "(Uncategorised)");

            foreach (var category in sortedPets)
            {
                Console.WriteLine(category.Key);
                Console.WriteLine(new string('-', category.Key.Length));

                foreach (var pet in category)
                {
                    Console.WriteLine(!string.IsNullOrWhiteSpace(pet.Name) ? pet.Name : "(Unnamed)");
                }

                Console.WriteLine();
            }
        }
    }
}
