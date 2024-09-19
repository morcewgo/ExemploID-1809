using Microsoft.Extensions.DependencyInjection;
namespace ExemploDI;

public interface ISingletonService : IReportServiceLifeTime
{
    ServiceLifetime IReportServiceLifeTime.Lifetime =>
        ServiceLifetime.Singleton;
}