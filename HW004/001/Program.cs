using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("введи первое число:");
string input1 = Console.ReadLine();
Console.WriteLine("введи второе число:");
string input2 = Console.ReadLine();
Console.WriteLine("знак действия:");
string sign = Console.ReadLine();

double operand1 = int.Parse(input1);
double operand2 = int.Parse(input2);


switch (sign)

{
    case "+":

        {
            Console.WriteLine($"результат сложения чисел:{operand1 + operand2}");
            break;
        }

    case "-":

        {
            Console.WriteLine($"результат вычитания чисел:{operand1 - operand2}");
            break;
        }

    case "*":

        {
            Console.WriteLine($"результат умножения чисел:{operand1 * operand2}");
            break;
        }

    case "/":

        {
            if (operand2 != 0)
            {
                Console.WriteLine($"результат деления чисел:{operand1 / operand2}");
            }
            else 
            { 
                Console.WriteLine("на ноль делить нельзя"); 
            }
            break;
        }

    default:

        {
            Console.WriteLine("я на это пойти не могу");
            break;
        }


}