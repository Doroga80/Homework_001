//Сгенерируйте массив случайных чисел размерностью m*n
// (размер вводится с клавиатуры). Вывести на экран красиво
// таблицей. Перемешать случайным оброзом элементы массива,
// причем чтобы кахдый гарантированно переместился на другое
// место (возможно для этого удобно будкт использовать множества)
// и выполнить это за m*n/2 интераций. Тоесть если массив
// три на четыре, то надо выполнить не более 6 интераций.
// И далее вывести на экран как таблицу.

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetRandomArray()
{
    var result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}
int[,] mas = GetRandomArray();
Console.WriteLine("Начальный массив :");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mas[i, j]}\t");
    }
    Console.WriteLine();
}
for (int i = 0; i < mas.Length * 10; i++)
{
    int r1 = new Random().Next(0, rows);
    int r2 = new Random().Next(0, rows);
    int c1 = new Random().Next(0, columns);
    int c2 = new Random().Next(0, columns);
    int temp = mas[r1, c1];
    mas[r1, c1] = mas[r2, c2];
    mas[r2, c2] = temp;
}
void printArray(int[,] mas)
{
    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
        {
            var cur = mas[r, c].ToString();
            cur = cur.Length == 2 ? cur : (" " + cur);
            Console.Write($"{cur}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Отсортированный массив : ");
printArray(mas);