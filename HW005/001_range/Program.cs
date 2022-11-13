Console.Write("введи первое число: ");
int operand1 = int.Parse(Console.ReadLine());
Console.Write("введи второе число (пожалуйста больше первого, а то я пока не знаю как быть в таком случае): ");
int operand2 = int.Parse(Console.ReadLine());
Console.Write("\n");
if (operand2 > operand1)
{
    int count = (operand2 - 1) - operand1;
    Console.WriteLine($"а теперь - магия! Ниже появились цифры, находящиеся в диапазоне между {operand1} и {operand2}");
    Console.Write("\n");
    for (int i = 0; i < count; i++)
    { Console.WriteLine($"{++operand1}"); }

}
else
{
    Console.WriteLine("я ж просил, чтобы второе число было больше!");
}
