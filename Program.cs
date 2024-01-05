using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using LocalNetProject.Services;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services => {
        services.AddSingleton<IGraphClientService, GraphClientService>();
    })
    .Build();

host.Run();
