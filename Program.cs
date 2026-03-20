Console.WriteLine("Bem vindo ao MiniBank!");

var novoCliente = new Cliente ();
novoCliente.Nome = "Ana Luisa Miguel Paterno Lima";
novoCliente.CPF = "123.456.902-34";
novoCliente.Email = "teste@sp.senac.br";

var novaContaBancaria = new ContaBase("12345-6", 1000m, novoCliente);

novaContaBancaria.Depositar(1500m);
novaContaBancaria.Sacar (0m);

Console.WriteLine($"{novoCliente.Nome} - Saldo: {novaContaBancaria.Saldo}");   
