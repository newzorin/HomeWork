Console.Write("Введите число A:");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int b1 = Convert.ToInt32(Console.ReadLine());

int stepen(int a, int b)
{
    int c = a;
    for (int i = 1; i < b; i++)
    {
        a = a*c;
    }
    return a;
}

int stepenA = stepen(a1,b1);
Console.Write(stepenA);