Console.WriteLine("введи значение радиуса основания цилиндра:");
string r_str = Console.ReadLine();
Console.WriteLine("введи значение высоты цилиндра:");
string h_str = Console.ReadLine();


double r = int.Parse(r_str);
double h = int.Parse(h_str);
const double pi = 3.14159;

double V = pi * Math.Pow(r, 2)*h;
double S = pi * 2 * r*(r+h);


Console.WriteLine($"площадь поверхности цилиндра с радиусом основания {r} и высотой {h}: {S}");
Console.WriteLine($"объём цилиндра с радиусом основания {r} и высотой {h}: {V}");