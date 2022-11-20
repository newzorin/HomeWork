
double[] FindXY(double b2, double b1, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


Console.WriteLine("Введите k1");
int k11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
int b11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int k22 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int b22 = Convert.ToInt32(Console.ReadLine());

double[] nameArray = FindXY(b22, b11, k11, k22);
PrintArray(nameArray);

