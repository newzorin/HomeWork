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

Double[] SumMatrixRndInt(int[,] matrix)
{
    int a = matrix.GetLength(1);
    Double[] array = new Double[a]; 
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1) + 1; j++)
    {
        array[j] = sum / 3;
        sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }

    }
    return array;
}

void PrintArray(Double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[,] arraymatrix1 = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(arraymatrix1);
Double[] result = SumMatrixRndInt(arraymatrix1);
PrintArray(result);