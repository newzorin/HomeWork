
int[] CreateArray( int a)
{
int[] array = new int[a]; 
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 101);
}
return array;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]+" ");
}
}

int[] nameArray = CreateArray(8);
PrintArray(nameArray);