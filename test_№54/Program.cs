Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[rows, column];

void FillArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            num[i, j] = Convert.ToInt32(new Random().Next(0, 100));
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{num[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void SortRowsArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < column - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
try
{
    Console.WriteLine("Начальный массив");
    FillArray();
    PrintArray();
    Console.WriteLine("Отсортированный массив");
    SortRowsArray(num);
    PrintArray();
}
catch
{
    Console.WriteLine("error");
}


