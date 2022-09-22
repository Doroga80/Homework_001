Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}

void Summ(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {summ} ");
        return;
    }
    Summ(m, n - 1, summ);
}

try
{
    Summ(m, n, temp = 0);
    System.Console.WriteLine();
}
catch
{
    Console.WriteLine("error");
}
