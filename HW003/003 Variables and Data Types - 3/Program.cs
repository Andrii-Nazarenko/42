Console.WriteLine("введи значение радиуса:");
string r_str = Console.ReadLine();


double r = int.Parse(r_str);
const double pi = 3.14;

double S=pi*Math.Pow(r,2);
double L = pi * 2 * r;


Console.WriteLine($"площдь круга с радиусом {r}: {S}");
Console.WriteLine($"длина окружности с радиусом {r}: {L}");