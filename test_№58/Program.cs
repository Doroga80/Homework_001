Console.Write("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[rows1, column1];
int[,] matrix2 = new int[rows2, column2];
int[,] productMatrix = new int[rows1, column2];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 11));
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void ProductMatrix(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(0); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}
try
{
    FillArray(matrix1);
    Console.WriteLine($"Первая матрица:");
    PrintArray(matrix1);
    FillArray(matrix2);
    Console.WriteLine($"Вторая матрица:");
    PrintArray(matrix2);
    ProductMatrix(matrix1, matrix2);
    Console.WriteLine($"Произведение первой и второй матриц:");
    PrintArray(productMatrix);
}
catch
{
    Console.WriteLine("error");
}

