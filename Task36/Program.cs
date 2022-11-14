int[] CreateArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}
int SumArray(int[] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        a = a + array[i];
    }
    return a;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] nameArray = CreateArray(5);
PrintArray(nameArray);
int result = SumArray(nameArray);
Console.WriteLine($"сумма элементов стояших на нечетных позициях = {result}");
