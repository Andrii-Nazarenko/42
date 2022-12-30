Console.Write("введи число:");
string input1 = Console.ReadLine();
int number = int.Parse(input1);
Console.WriteLine("Нажми 1, если хочешь узнать отрицательное или положительное число ты ввёл");
Console.WriteLine("Нажми 2, если хочешь узнать простое ли число ты ввёл");
Console.WriteLine("Нажми 3, если хочешь узнать делится ли оно нацело на 2,3,5,6 или 9");
Console.Write("Твой выбор:");
string action = Console.ReadLine();


switch (action)
{
    case "1":
        {
            Sign(number);
            break;
        }
    case "2":
        {
            Simple(number);
            break;
        }
    case "3":
        {
            Div(number);
            break;
        }
    default:
        {
            Console.WriteLine("выбор не понятен");
            break;
        }
}


static void Sign(int num)
{
    if (num >= 0)
    {
        Console.WriteLine("Число положительное");
    }
    else
    {
        Console.WriteLine("Число отрицательное");
    }
}
static void Simple(int num)
{
    bool isSimple = true;
    if (num > 0)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                isSimple = false;

        }
        if (isSimple == true)
        {
            Console.WriteLine("Число простое");
        }
        else
        {
            Console.WriteLine("Число не простое");
        }
    }
    else
    {
        Console.WriteLine("Простые числа - это числа больше 0. ты ввёл отрицательное(или 0)");
    }
}

static void Div(int num)
{
    if (num % 9 == 0 || num % 6 == 0 || num % 5 == 0 || num % 3 == 0 || num % 2 == 0)
    {

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} без остатка делится на 2");
        }
        if (num % 3 == 0)
        {
            Console.WriteLine($"{num} без остатка делится на 3");
        }
        if (num % 5 == 0)
        {
            Console.WriteLine($"{num} без остатка делится на 5");
        }
        if (num % 6 == 0)
        {
            Console.WriteLine($"{num} без остатка делится на 6");
        }
        if (num % 9 == 0)
        {
            Console.WriteLine($"{num} без остатка делится на 9");
        }
    }
    else
    {
        Console.WriteLine("число не делится на 2, 3, 5, 6 и 9");
    }
}
