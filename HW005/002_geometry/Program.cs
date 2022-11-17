//Random r = new Random();
//int height1 = r.Next(5, 10);
//int width = r.Next(11, 15);
// сохранил на память
Console.Write("введи высоту прямоугольника: ");
int heightRectangle = int.Parse(Console.ReadLine());
Console.Write("ввуди ширину прямоугольника: ");
int widhtRectangle = int.Parse(Console.ReadLine());

for (int rowCounter = 0; rowCounter < heightRectangle; rowCounter++)
{
    for (int columnCounter = 0; columnCounter < widhtRectangle; columnCounter++)
    {
        Console.Write("O ");
    }

    Console.WriteLine();
}

Console.Write("\n");


Console.Write("введи размер катета равнобедренного прямоугольного треугольника: ");

int longLeg = int.Parse(Console.ReadLine());

for (int i = 0; i < longLeg; i++)
{

    for (int j = 0; j <= i; j++)
    {
        Console.Write("# ");
    }


    Console.WriteLine();
}
Console.Write("\n");


Console.Write("введи высоту равнобедренного треугольника:");

int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = height; j > i; j--)
    {
        Console.Write("  ");
    }

    for (int j = 0; j <= i; j++)
    {
        Console.Write("Ж ");
    }

    for (int j = height; j < i + height; j++)
    {
        Console.Write("Ж ");
    }

    Console.WriteLine();
}

Console.Write("\n");

Console.Write("введи пловину диагонали ромба:");
// на самом деле ромб получается на одну клеточку короче, но зато у него острые углы

int halfDiagonal = int.Parse(Console.ReadLine());

for (int i = 0; i < halfDiagonal; i++)
{
    for (int j = halfDiagonal; j > i; j--)
    {
        Console.Write("  ");
    }

    for (int j = 0; j <= i; j++)
    {
        Console.Write("D ");
    }

    for (int j = halfDiagonal; j < i + halfDiagonal; j++)
    {
        Console.Write("D ");
    }

    Console.WriteLine();
}
for (int i = 0; i <= halfDiagonal; i++)
{
    for (int j = 0; j <= i + 1; j++)
    {
        Console.Write("  ");
    }

    for (int j = halfDiagonal - 1; j > i; j--)
    {
        Console.Write("D ");
    }


    for (int j = halfDiagonal - 1; j > i + 1; j--)
    {
        Console.Write("D ");
    }
    Console.WriteLine();
}