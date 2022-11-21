int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}
int FindNumMatrix(int[,] matrix, int rows, int columns)
{
    int res = matrix[rows, columns];
    return res;
}

Console.WriteLine("Введите позицию i искомого элемента");
int i1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию j искомого элемента");
int j1 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(array1);

if (i1 <= 4 && j1 <= 4)
{
   int result = FindNumMatrix(array1, i1, j1);
   Console.WriteLine($"Искомые элемент массива = {result} ");
}  
else
{
    Console.WriteLine($"Элемент не найден");
}