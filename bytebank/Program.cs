using bytebank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "Andre";
contaAndre.numero_agencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100;

Console.WriteLine("Saldo da conta do Andre = " + contaAndre.saldo);

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Souza";
contaMaria.numero_agencia = 17;
contaMaria.conta = "1010-5";
contaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria = " + contaMaria.saldo);

contaAndre.Transferir(50, contaMaria);
Console.WriteLine("Saldo do Andre = " + contaAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaMaria.saldo);

/*
contaAndre.Depositar(100);
Console.WriteLine("Saldo da conta do Andre pós-credito = " + contaAndre.saldo);

if(contaAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do Andre pós-saque = " + contaAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque.");
}*/