//Программа, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.

string IsPolindrom()
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int oldnum = num;
    int revers = 0;
    while (num > 0)
    {
        int dig = num % 10;
        revers = revers * 10 + dig;
        num = num / 10;
    }
    if (oldnum == revers)
    {
        return $"Число является палиндромом";
    }
    else
    {
        return $"Число не является палиндромом";
    }
}
try
{
    Console.WriteLine(IsPolindrom());
}
catch
{
    Console.WriteLine("Необходимо ввести именно число");
    //throw;
}