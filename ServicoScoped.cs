namespace ExemploDI;

public class ServicoScoped : IScopedService
{ 
    Guid IReportServiceLifeTime.Id { get; } = Guid.NewGuid();
}
