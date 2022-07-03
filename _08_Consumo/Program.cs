using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Distância percorrida: ");
int distanciaPercorrida = int.Parse(Console.ReadLine()!);
Console.Write("Combustivel gasto: ");
double combustivelGasto = double.Parse(Console.ReadLine()!, info);

double consumoMedio = distanciaPercorrida / combustivelGasto;

Console.WriteLine($"Consumo médio = {consumoMedio.ToString("F3", info)}");