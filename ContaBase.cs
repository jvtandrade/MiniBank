public abstract class ContaBase : IConta
{
    public string Numero { get; }
    public decimal Saldo { get; private set; }
    public Cliente Titular { get; }

    protected ContaBase(string numeroConta, decimal saldoInicial, Cliente titular)
    {
        Numero = numeroConta;
        Saldo = saldoInicial;
        Titular = titular;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor depositado precisa ser positivo");
            return;
        } 

        Saldo += valor;

        Console.WriteLine($"Depósito de R$ {valor} na conta {Numero} realizado com sucesso!");
    }

    public abstract bool Sacar(decimal valor);

    public string ExibirExtrato() => $"Conta: {Numero} \nTitular: {Tilular.Nome} \nSaldo: R${Saldo:C}";

}