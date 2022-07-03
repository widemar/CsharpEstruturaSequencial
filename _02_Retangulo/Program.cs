using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Base do retângulo: ");
double baseR = double.Parse(Console.ReadLine()!, info);
Console.Write("Altura do retangulo: ");
double alturaR = double.Parse(Console.ReadLine()!, info);

double area = baseR * alturaR;
double perimetro = 2 * (baseR + alturaR);
double diagonal = Math.Sqrt(Math.Pow(baseR, 2) + Math.Pow(alturaR, 2));

Console.WriteLine($"AREA = {area.ToString("F4", info)}");
Console.WriteLine($"PERIMETRO = {perimetro.ToString("F4", info)}");
Console.WriteLine($"DIAGONAL = {diagonal.ToString("F4", info)}");