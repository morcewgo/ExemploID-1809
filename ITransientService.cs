using Microsoft.Extensions.DependencyInjection;
namespace ExemploDI;

public interface ITransientService : IReportServiceLifeTime
{
    ServiceLifetime IReportServiceLifeTime.Lifetime =>
        ServiceLifetime.Transient;
}