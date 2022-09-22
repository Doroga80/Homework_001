Console.Write("Введите количество строк двумерного массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива:");
int column = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[rows, column];
void PrintArray(double[,] mas)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{mas[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] mas)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            mas[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
        }
    }
}
try
{
    FillArray(num);
    Console.WriteLine();
    PrintArray(num);
}
catch
{
    Console.WriteLine("error");
}
