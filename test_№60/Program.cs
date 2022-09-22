Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z: ");
int z = Convert.ToInt32(Console.ReadLine());

void FillArray3D(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    temp[0] = new Random().Next(0, 101);
    for (int i = 1; i < temp.Length;)
    {
        int num = new Random().Next(10, 101);
        int j;
        for (j = 0; j < i; j++)
        {
            if (num == temp[j])
                break;
        }
        if (j == i)
        {
            temp[i] = num;
            i++;
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i},{j},{k})\t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
try
{
    int[,,] array3D = new int[x, y, z];
    FillArray3D(array3D);
    PrintArray(array3D);
}
catch
{
    Console.WriteLine("error");
}
