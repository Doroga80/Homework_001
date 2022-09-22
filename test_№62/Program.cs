Console.Write("Введите размер матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число с которого начнется заполнение матрицы: ");
int numStart = Convert.ToInt32(Console.ReadLine());

int[,] SpiralMatrix()
{
    int[,] matrix = new int[n, n];
    int i = 0;
    int j = 0;
    int count = 1;
    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = numStart;
        count++;
        numStart++;
        if (i <= j + 1 & i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j & i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j & i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return matrix;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($" {array[i, j]}\t");
            else Console.Write($" {array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
try
{
    int[,] spiral = SpiralMatrix();
    PrintArray(spiral);
}
catch
{
    Console.WriteLine("error");
}



