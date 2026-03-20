public sealed class ContaCorrente : ContaBase
{
    public decimal LimiteChequeEspecial { get; }
    public ContaCorrente(string numero, Cliente titular,
        decimal saldoInicial = 0,
        decimal limiteChequeEspecial = 500m)
        : base(numero, titular, saldoInicial)
    {
        LimiteChequeEspecial = limiteChequeEspecial;
    }

    public override bool Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor a ser sacado precisa ser positivo");
            return false;
        }

        if (Saldo + LimiteChequeEspecial < valor)
        {
            Console.WriteLine($"Saldo insuficiente. Saldo atual: R${Saldo}");
            return false;
        }

        Saldo -= valor;
        Console.WriteLine($"Saque de R${valor} na conta:{Numero} realizado com sucesso.");
        return true;
    }

    public override string ExibirExtrato() => base.ExibirExtrato() + $"\nLimite Cheque Especial: {LimiteChequeEspecial:C}";
}