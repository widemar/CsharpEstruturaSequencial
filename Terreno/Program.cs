using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;
Console.Write("Digite a largura do terreno: ");
double largura = double.Parse(Console.ReadLine()!, info);
Console.Write("Digite o comprimento do terreno: ");
double comprimento = double.Parse(Console.ReadLine()!, info);
Console.Write("Digite o valor do metro quadrado: ");
double valorMetro = double.Parse(Console.ReadLine()!, info);

double areaTerreno = largura * comprimento;
double precoTerreno = areaTerreno * valorMetro;

Console.WriteLine($"Area do terreno = {areaTerreno.ToString("F2", info)}");
Console.WriteLine($"Preço do terreno = {precoTerreno.ToString("F2", info)}");