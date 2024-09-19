using Microsoft.Extensions.DependencyInjection;
namespace ExemploDI;

public interface IScopedService : IReportServiceLifeTime
{
    ServiceLifetime IReportServiceLifeTime.Lifetime =>
        ServiceLifetime.Scoped;
}