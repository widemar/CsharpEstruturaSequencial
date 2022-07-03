using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Nome: ");
string nome = Console.ReadLine()!;
Console.Write("Valor por hora: ");
double valorPorHora = double.Parse(Console.ReadLine()!, info);
Console.Write("Horas trabalhadas: ");
int horasTrabalhadas = int.Parse(Console.ReadLine()!);

double pagamento = valorPorHora * horasTrabalhadas;

Console.WriteLine($"O pagamento para {nome} deve ser {pagamento.ToString("F2", info)}");