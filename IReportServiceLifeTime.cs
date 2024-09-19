using Microsoft.Extensions.DependencyInjection;
namespace ExemploDI;

public interface IReportServiceLifeTime
{
    public Guid Id { get; }
    public ServiceLifetime Lifetime { get; }
}
