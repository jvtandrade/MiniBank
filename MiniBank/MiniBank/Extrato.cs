using System;

namespace MiniBank;

public class Extrato
{
    private readonly List<Transacao> transacoes = [];
    public IReadOnlyList<Transacao> Transacoes =>
        transacoes.AsReadOnly();

    public void Registrar(Transacao transacao) => //novo método
        transacoes.Add(transacao);

    public void Imprimir()
    {
        Console.WriteLine("===EXTRATO===");
        foreach (var transacao in transacoes)
            Console.WriteLine(transacao);
        Console.WriteLine("==============");

    }
}