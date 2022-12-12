using BityBank.Conta;
using BityBank.Titular;

//ContaCorrente ContaDoAndre = new ContaCorrente();
//ContaDoAndre.titular = "Andre Silva";
//ContaDoAndre.numero_agencia= 15;
//ContaDoAndre.conta = " 1010-X";
//ContaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do Andre = " + ContaDoAndre.saldo);

//ContaDoAndre.Depositar(100);
//Console.WriteLine("Saldo da Conta do Andre deppois de receber = " + ContaDoAndre.saldo);

//if (ContaDoAndre.Saque(300) == true)
//{
//  Console.WriteLine("Conta do Andre pós saque = " + ContaDoAndre.saldo);
//}
//else
//{
//   Console.WriteLine("Saldo insuficiente");
//}
//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "maria Santos";
//contaDaMaria.numero_agencia = 18;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

//ContaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("saldo conta do Andre = " + ContaDoAndre.saldo);
//Console.WriteLine("Saldo da conta da Maria = "+ contaDaMaria.saldo);

Cliente cliente= new Cliente();
cliente.nome = "Andre Souza";
cliente.cpf = "123546543";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numero_agencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("Cpf = " + conta.titular.cpf);
Console.WriteLine("Profissao = " + conta.titular.profissao);
Console.WriteLine("Nº Conta = " + conta.conta);
Console.WriteLine("Saldo = " + conta.saldo);
Console.WriteLine("Nº Agência = " + conta.numero_agencia);

ContaCorrente conta2 = new ContaCorrente();
conta2.titular= new Cliente();
conta2.titular.nome = "José Souza";
conta2.titular.profissao = "Tester";
conta2.titular.cpf = "987654321";
conta2.conta = "9999-X";
conta2.numero_agencia = 18;
conta2.saldo = 500;

Console.WriteLine(conta2.titular.nome);


