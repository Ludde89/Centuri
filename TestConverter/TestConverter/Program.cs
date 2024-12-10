// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestConverter;
using TestConverter.Services;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddServices();
using IHost host = builder.Build();
Run(host.Services);

await host.RunAsync();

Console.WriteLine("Hello, World!");

static void Run(IServiceProvider hostProvider)
{
    using var service = hostProvider.CreateScope();
    var convertDataService = service.ServiceProvider.GetRequiredService<ConvertDataService>();

    var result = convertDataService.Run();
    Console.WriteLine(result);
}