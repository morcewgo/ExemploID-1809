namespace ExemploDI;

public class ServicoTransient : ITransientService
{
    Guid IReportServiceLifeTime.Id { get; } = Guid.NewGuid();
}