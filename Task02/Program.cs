Console.WriteLine("Введите целое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("числа ровны");
}

else
{



if (number1 > number2)
{
    Console.WriteLine($"число {number1} больше числа {number2} ");
}

else

{
    Console.WriteLine($"число {number2} больше числа {number1} ");
}

}