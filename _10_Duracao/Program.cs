Console.Write("Digite a duração em segundos: ");
int duracao = int.Parse(Console.ReadLine()!);

int horas = duracao / 3600;
int minutos = (duracao - 3600 * horas) / 60;
int segundos = duracao - (3600 * horas + minutos * 60);

Console.WriteLine($"{horas}:{minutos}:{segundos}");