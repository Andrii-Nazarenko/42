Console.Write("курс валюты А к валюте В:");
string input1 = Console.ReadLine();

Console.Write("введи сумму в валюте А:");
string input2 = Console.ReadLine();


double rate = int.Parse(input1);
double amountA = int.Parse(input2);

Console.WriteLine($"сумма ввалюте В после обмена: {currencyExchange(rate, amountA)}");

static double currencyExchange (double a, double b)
{
    double result = a * b;
    return result;
}