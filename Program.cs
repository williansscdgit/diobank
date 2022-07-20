using diobank.Classes;

var conta1 = new Conta(diobank.Enum.TipoConta.pessoaFisica, "Willian Silva", 0, 0);
var conta2 = new Conta(diobank.Enum.TipoConta.pessoaFisica, "Carla Araújo", 0, 0);

Console.WriteLine("Depósito");
conta1.Depositar(100);
conta2.Depositar(100);
Console.WriteLine($"{conta1}\n{conta2}\n");

Console.WriteLine("Saque");
conta1.Sacar(20);
conta2.Sacar(30);
Console.WriteLine($"{conta1}\n{conta2}\n");

Console.WriteLine("Transferencia");
conta2.Transferir(conta1,10);
Console.WriteLine($"{conta1}\n{conta2}\n");


