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

int[,] Matrix1 = new int[4, 4];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= 16)
{
    Matrix1[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < 3)
        j++;
    else if (i < j && i + j >= 3)
        i++;
    else if (i >= j && i + j > 3)
        j--;
    else
        i--;
}

PrintMatrix(Matrix1);