namespace ExemploDI;

public class ServicoSingleton : ISingletonService
{
    Guid IReportServiceLifeTime.Id { get; } = Guid.NewGuid();
}