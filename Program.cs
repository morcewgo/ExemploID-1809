using ExemploDI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<ITransientService, ServicoTransient>();
builder.Services.AddScoped<IScopedService, ServicoScoped>();
builder.Services.AddSingleton<ISingletonService, ServicoSingleton>();

builder.Services.AddTransient<ServicoMostrarCicloDeVida>();

using var host = builder.Build();

ExemploCicloDeVida(host.Services, "Primeira Execução");
ExemploCicloDeVida(host.Services, "Segunda Execução");

await host.RunAsync();
return;

static void ExemploCicloDeVida(IServiceProvider hostProvider, string lifetime)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    ServicoMostrarCicloDeVida logger = provider.GetRequiredService<ServicoMostrarCicloDeVida>();

    logger.MostrarDetalhes(
        $"{lifetime}: Chamada 1 para ServicoMostrarCicloDeVida()");

    Console.WriteLine("...");

    logger = provider.GetRequiredService<ServicoMostrarCicloDeVida>();
    logger.MostrarDetalhes(
        $"{lifetime}: Chamada 1 para ServicoMostrarCicloDeVida()");

    Console.WriteLine();
}
