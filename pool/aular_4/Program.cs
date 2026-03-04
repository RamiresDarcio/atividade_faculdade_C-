
using aular_4;
//criado de dados 
conta_bancaria_p  conta = new();
conta_bancaria_p telefone = new();
conta_bancaria_p codigo = new();
conta_bancaria_p valor = new();
conta_bancaria_p local = new();
conta_bancaria_p empresa = new();
//caminho dos dados 
conta.Titular = "robetinho";
valor.Saldo = 54;
codigo.Senha = "robe435";
telefone.Numero = "6194445023";
local.Agencia = 12;
empresa.Tipo = "banco_brasil";    
//saida dos dados 
Console.WriteLine(conta.Titular);
Console.WriteLine(valor.Saldo);
Console.WriteLine(codigo.Senha);
Console.WriteLine(telefone.Numero);
Console.WriteLine(local.Agencia);
Console.WriteLine(empresa.Tipo);