Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
void PrintNum(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    PrintNum(num -1);
}

PrintNum(num);