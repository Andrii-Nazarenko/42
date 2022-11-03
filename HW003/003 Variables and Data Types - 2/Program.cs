Console.WriteLine("введи значение x:");
string x_str = Console.ReadLine();
Console.WriteLine("введи значение y:");
string y_str = Console.ReadLine();
Console.WriteLine("введи значение z:");
string z_str = Console.ReadLine();

double x = int.Parse(x_str);
double y = int.Parse(y_str);
double z = int.Parse(z_str);


Console.WriteLine($"Среднее арифметическое: {(x + y + z) / 3}");


Console.ReadLine();
