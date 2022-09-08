//Программа, которая принимает на вход число и выдает сумму цифр
//числа.

string SumDig()
{
    Console.WriteLine("Введите число ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while(n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    return $"Сумма цифр равна {sum}";
}
try
{
    Console.WriteLine(SumDig());
}
catch
{
    Console.WriteLine("Необходимо вводить именно число");
}
