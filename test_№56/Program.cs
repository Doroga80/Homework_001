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
            num[i, j] = Convert.ToInt32(new Random().Next(1, 100));
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
string RowsMinSum(int [,] array)
{
int minSum = int.MaxValue;
int minInd = 0;
for (int i = 0; i < rows; i++)
{
    int currentSum = 0;
    for (int j = 0; j < column; j++)
    {
        currentSum += array[i, j];
    }
   if (currentSum < minSum)
    {
        minSum = currentSum;
        minInd = i;
    } 
}
return $"Строка с минимальной суммой элементов находится под № {minInd+1}, сумма = {minSum}";
}

try
{
FillArray();
PrintArray();
Console.WriteLine(RowsMinSum(num));
}
catch
{
  Console.WriteLine("error");
}


