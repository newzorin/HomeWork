Console.WriteLine("Введите натуральное число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumNum(int m, int n)
{
    if (m < n)
    {
        sum = sum + m;
        SumNum(m + 1, n);
    }

    if (m == n)
    {
        sum = sum + m;
    }

    return sum;
}
int res = SumNum(num1, num2);
Console.WriteLine(res);
