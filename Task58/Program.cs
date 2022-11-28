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

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum = sum + firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}



Console.WriteLine("Введите количество строк первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1-й матрицы и строк 2-й матрицы");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2-й матрицы");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = CreateMatrixRndInt(m, n, 0, 9);
int[,] secondMartrix = CreateMatrixRndInt(n, p, 0, 9);
int[,] resultMatrix = CreateMatrixRndInt(m, p, 0, 9);
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine("первая матрица");
PrintMatrix(firstMartrix);
Console.WriteLine("вторая матрица");
PrintMatrix(secondMartrix);
Console.WriteLine("произведение матриц");
PrintMatrix(resultMatrix);