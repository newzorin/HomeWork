Console.WriteLine("Введите целое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");

int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число");

int number3 = Convert.ToInt32(Console.ReadLine());

int max1 = number1; 

if (number1 == number2 && number1 == number3)
{
    Console.WriteLine("числа ровны");
}

else
{



if (number2 > max1)
{
    max1 = number2;
}

if (number3 > max1)
{
    max1 = number3;
}

Console.WriteLine($"число {max1} самое большое");

}

