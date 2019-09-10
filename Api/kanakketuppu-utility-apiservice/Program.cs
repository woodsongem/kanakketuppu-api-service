using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Autofac.Extensions.DependencyInjection;

namespace kanakketuppuapiservice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The ConfigureServices call here allows for
            // ConfigureContainer to be supported in Startup with
            // a strongly-typed ContainerBuilder. If you don't
            // have the call to AddAutofac here, you won't get
            // ConfigureContainer support. This also automatically
            // calls Populate to put services you register during
            // ConfigureServices into Autofac.
            WebHost.CreateDefaultBuilder(args)
            .ConfigureServices(services => services.AddAutofac())
            .UseStartup<Startup>()
            .Build()
            .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
