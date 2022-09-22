Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[rows, column];

int[,] PrintArray(int rows, int column)
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
string SearchIndex(int[,] array)
{
    Console.Write("Введите строку искомого числа: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец искомого числа: ");
    int x = Convert.ToInt32(Console.ReadLine());
    string result;
    if (y > rows | x > column)
        result = "Tакого числа нет";
    else
    {
        result = $"Число с индексом[{y},{x}] = {num[y, x]}";
    }
    return result;
}
try
{
    int[,] mas = PrintArray(rows,column);
    Console.WriteLine();
    Console.WriteLine(SearchIndex(mas));
}
catch
{
    Console.WriteLine("error");
}
