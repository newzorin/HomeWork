Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = number1 % 2;

if (number2 > 0)
{
    Console.WriteLine($"число {number1} не четное");
}

else
{
    Console.WriteLine($"число {number1} четное");
}




