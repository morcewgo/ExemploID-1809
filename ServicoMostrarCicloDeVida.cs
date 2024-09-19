namespace ExemploDI;

internal sealed class ServicoMostrarCicloDeVida (
    ITransientService servicoTransient,
    IScopedService servicoScoped,
    ISingletonService servicoSingleton)
{
    private static void MostrarServico<T>(T servico, string mensagem)
        where T: IReportServiceLifeTime =>
    Console.WriteLine($"{typeof(T).Name}: {servico.Id} ({mensagem}");
 
    public void MostrarDetalhes(string detalhes)
    {
        Console.WriteLine(detalhes);
        
        MostrarServico(servicoTransient, "Muda sempre");
        MostrarServico(servicoScoped, "Muda no escopo");
        MostrarServico(servicoSingleton, "Nunca muda");
    }
}