using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Unify.PetStore.Sample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Use ServiceCollection for dependency injection in order to make use of AddHttpClient which will correctly manage HttpClient resources.
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IPetStoreSample, PetStoreSample>()
                .BuildServiceProvider();

            // Execute the PetStore sample application
            var petStoreSample = serviceProvider.GetService<IPetStoreSample>();
            await petStoreSample.Run();
        }
    }
}
