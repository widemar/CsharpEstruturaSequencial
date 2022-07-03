using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Preço unitário do produto: ");
double precoUnitario = double.Parse(Console.ReadLine()!, info);
Console.Write("Quantidade comprada: ");
int quantidade = int.Parse(Console.ReadLine()!);
Console.Write("Dinheiro recebido: ");
double dinheiroRecebido = double.Parse(Console.ReadLine()!, info);

double troco = dinheiroRecebido - precoUnitario * quantidade;

Console.WriteLine($"TROCO = {troco.ToString("F2", info)}");