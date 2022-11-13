Console.WriteLine("Сколько сегодня доставок? ");
int ourCliens = int.Parse(Console.ReadLine());

int result = 1;

do
{
    result *= ourCliens--;    
}
while (ourCliens > 0);
Console.Write("Количество возможных марщрутов: {0}", result);