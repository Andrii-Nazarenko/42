using System;

Console.Write("введи первое число:");
string input1 = Console.ReadLine();

Console.Write("введи второе число:");
string input2 = Console.ReadLine();

Console.Write("знак действия:");
string sign = Console.ReadLine();

int operand1 = int.Parse(input1);
int operand2 = int.Parse(input2);

switch (sign)
{
    case "+":
        {
            Console.WriteLine($"{input1}{sign}{input2}={add(operand1, operand2)}");
            break;
        }
    case "-":
        {
            Console.WriteLine($"{input1}{sign}{input2}={sub(operand1, operand2)}"); 
            break;
        }
    case "*":
        {
            Console.WriteLine($"{input1}{sign}{input2}={mul(operand1, operand2)}");
            break;
        }
    case "/":
        {
          
             Console.WriteLine($"{input1}{sign}{input2}={div(operand1, operand2)}");
             break;
            

        }
    default:

        {
            Console.WriteLine("что-то введено не так");
            break;
        }

}

static int add(int a, int b)
{
    int result = a + b;
    return result;
}

static int sub(int a, int b)
{
    int result = a - b;
    return result;
}

static int mul(int a, int b)
{
    int result = a * b;
    return result;
}

static double div(double a, double b)
{
    //if (b != 0)
    //{
    double result = a / b;
    return result;
    //}

    //else
    //{
    //    Console.WriteLine("на ноль делить нельзя");
    //    return 0;
    //}
}

