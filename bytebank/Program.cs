using bytebank;
using bytebank.Contas;
using bytebank.Titular;



//Cliente cliente = new Cliente();
//cliente.Nome = "Andre Silva";
//cliente.Cpf = "12312312312";
//cliente.Profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.Titular = cliente;
//conta.Conta = "1010-x";
//conta.Numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.Titular.Nome);
//Console.WriteLine("Cpf = " + conta.Titular.Cpf);
//Console.WriteLine("Profissao = " + conta.Titular.Profissao);
//Console.WriteLine("Numero da conta = " + conta.Conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("Numero da Agência = " + conta.Numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.Titular = new Cliente();
//conta2.Titular.Nome = "Jose";
//conta2.Titular.Profissao = "Tester";
//conta2.Titular.Cpf = "32132132112";
//conta2.Conta = "999-x";
//conta2.Numero_agencia = 18;
//conta2.saldo = 500;

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);








