using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;
const double pi = 3.14159;

Console.Write("Digite o valor do raio do circulo: ");
double raio = double.Parse(Console.ReadLine()!, info);

double area = pi * Math.Pow(raio, 2);

Console.WriteLine($"AREA = {area.ToString("F3", info)}");