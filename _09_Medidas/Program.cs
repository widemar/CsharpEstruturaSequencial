using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Digite a medida A: ");
double a = double.Parse(Console.ReadLine()!, info);
Console.Write("Digite a medida B: ");
double b = double.Parse(Console.ReadLine()!, info);
Console.Write("Digite a medida C: ");
double c = double.Parse(Console.ReadLine()!, info);

double areaQuadrado = Math.Pow(a, 2);
double areaTriangulo = a * b / 2;
double areaTrapezio = (a + b) * c / 2;

Console.WriteLine($"AREA DO QUADRADO = {areaQuadrado.ToString("F4", info)}");
Console.WriteLine($"AREA DO TRIÂNGULO = {areaTriangulo.ToString("F4", info)}");
Console.WriteLine($"AREA DO TRAPÉZIO = {areaTrapezio.ToString("F4", info)}");