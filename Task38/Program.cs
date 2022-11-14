double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double MimMaxtArray(double[] array)
{
    double maxI = array[0];
    double minI = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxI)
        {
            maxI = array[i];
        }

        if (array[i] < minI)
        {
            minI = array[i];
        }


    }
    double res = maxI - minI;
    return res;
}
double[] nameArray = CreateArray(3, 1, 9);
PrintArray(nameArray);
double result = MimMaxtArray(nameArray);
Console.WriteLine($" разнича между максимальным и минимальным элементами масива = {result}");

