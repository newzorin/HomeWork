int sumnum(int a)
{
    int b = 0;
    int summa = 0;
    while (a > 0)
    {
        b = a % 10;
        a = a / 10;
        summa = summa + b;
    }
    return summa;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int result = sumnum(num);
Console.WriteLine(result);