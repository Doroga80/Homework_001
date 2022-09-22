Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[rows, column];
int [] summ = new int [column];
int[,] PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            num[i, j] = Convert.ToInt32(new Random().Next(0, 100));
            Console.Write($"{num[i, j]}\t ");
        }
        Console.WriteLine();
    }
    return num;
}

int [] PrintAverage(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            summ[i] += array[j, i];
        }
    }
    foreach (double elements in summ)
    {
        Console.Write($"{elements / column} \t");
    }
    Console.WriteLine();
    return summ;
}
try
{
    int[,] mas = PrintArray();
    Console.WriteLine();
    Console.WriteLine(PrintAverage(mas));
}
catch
{
    Console.WriteLine("error");
}
