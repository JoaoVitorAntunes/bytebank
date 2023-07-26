using bytebank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "Andre";
contaAndre.numero_agencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100;

Console.WriteLine("Saldo da conta do Andre = " + contaAndre.saldo);

contaAndre.Depositar(100);
Console.WriteLine("Saldo da conta do Andre pós-credito = " + contaAndre.saldo);

if(contaAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do Andre pós-saque = " + contaAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque.");
}