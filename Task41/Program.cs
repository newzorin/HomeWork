int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int PositiveNumber(int[] array)
{
    int a = 0;
   for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            a++;
        }
    }

    return a;
}



Console.WriteLine("Введите число");
int sizeArrey = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {sizeArrey} чисел");

int[] nameArray = CreateArray(sizeArrey);
PrintArray(nameArray);
int result = PositiveNumber(nameArray);
Console.WriteLine($"количество положительных чисел = {result}");