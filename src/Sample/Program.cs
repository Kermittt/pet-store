using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Unify.PetStore.Client;

namespace Unify.PetStore.Sample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Use ServiceCollection for dependency injection in order to make use of AddHttpClient which will correctly manage HttpClient resources.
            var services = new ServiceCollection()
                .AddSingleton<IPetStoreSample, PetStoreSample>();

            services.AddPetHttpClient("http://petstore.swagger.io/v2/");

            var serviceProvider = services.BuildServiceProvider();


            // Execute the PetStore sample application
            var petStoreSample = serviceProvider.GetService<IPetStoreSample>();
            await petStoreSample.Run();
        }
    }
}
