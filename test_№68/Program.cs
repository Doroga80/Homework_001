Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Ack(m - 1, 1);
    else
        return Ack(m - 1, Ack(m, n - 1));
}

System.Console.WriteLine($"Функция Аккермана для чисел M = {m} и N = {n} равна : {Ack(m,n)}");