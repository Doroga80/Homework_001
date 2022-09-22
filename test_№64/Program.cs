Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

static void Foo(int m, int n)
{
    if (m > n)
    {
        Console.Write("{0} ", m);
        Foo(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write("{0} ", m);
        Foo(m + 1, n);
    }
    
}
try
{
    Foo(m, n);
    Console.WriteLine();
}
catch
{
    Console.WriteLine("error");
}


