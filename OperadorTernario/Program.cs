Console.Write("\nOperador Ternário");

bool ativo = false;
string status = ativo == true ? " \nCadastro ativo no sistema" : "Cadastro não está ativado";
Console.WriteLine(status);

Console.WriteLine("================================");

string nome1 = "Gabrielle";
string status1 = nome1 == "Gabrielle" ? "Os nomes são iguais" :  "Os nomes são diferentes";
Console.WriteLine(status1);

Console.WriteLine("================================");

int numero1 = 24;
string nome2 = "Paulo Cesar";
var numeroString = numero1 == 20 ? $"{nome2}" :  $"{nome1}";
Console.WriteLine(numeroString);