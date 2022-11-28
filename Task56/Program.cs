void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
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

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

int[] SumMatrixRndInt(int[,] matrix)
{
    int[] array1 = new int[matrix.GetLength(0)];
    int sum = 0;
    int temp = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }

        temp++;
        array1[temp] = sum;
        sum = 0;
    }
    return array1;
}

int MimArray(int[] array)
{
    int minI = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minI)
        {
            minI = array[i];
        }
    }
    return minI;
}

int[,] array2d = CreateMatrixRndInt(4, 3, 0, 9);
PrintMatrix(array2d);
int[] newarray2d = SumMatrixRndInt(array2d);
PrintArray(newarray2d);
int res = MimArray(newarray2d);
Console.WriteLine($"минимальное число = {res}");


