using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
string nomeUm = Console.ReadLine()!;
Console.Write("Idade: ");
int idadeUm = int.Parse(Console.ReadLine()!);

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
string nomeDois = Console.ReadLine()!;
Console.Write("Idade: ");
int idadeDois = int.Parse(Console.ReadLine()!);

double idadeMedia = (double)(idadeUm + idadeDois) / 2;

Console.WriteLine($"A idade média de {nomeUm} e {nomeDois} é de {idadeMedia.ToString("F1", info)}");