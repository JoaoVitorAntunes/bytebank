﻿using bytebank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "Andre";
contaAndre.numero_agencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100;

Console.WriteLine("Saldo da conta do Andre =" + contaAndre.saldo);

contaAndre.Depositar(100);

Console.WriteLine("Saldo da conta do Andre pós-credito =" + contaAndre.saldo);