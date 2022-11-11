Console.WriteLine("введи число:");
string input1 = Console.ReadLine();


int operand1 = int.Parse(input1);

if (0 <= operand1 && operand1 <= 14)

{
    Console.WriteLine("число принадлежит промежутку [0-14]");
}

else if (15 <= operand1 && operand1 <= 35)

{
    Console.WriteLine("число принадлежит промежутку [15-35]");
}

else if (36 <= operand1 && operand1 <= 50)

{
    Console.WriteLine("число принадлежит промежутку [36-50]");
}

else if (51 <= operand1 && operand1 <= 100)

{
    Console.WriteLine("число принадлежит промежутку [51-100]");
}

else

{
    Console.WriteLine("число или больше 100 или меньше нуля. можно было написать ещё один ELSE IF и определить конкретней, но кому это нужно....");
}
