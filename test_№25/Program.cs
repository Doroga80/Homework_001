//Программа, которая принимает на вход два числа(A и B) и возвращает
//число A в натуральную степень B.

string Stepen()
{
    Console.WriteLine("Введите число A:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    int b = Convert.ToInt32(Console.ReadLine());
    int st = 1;
    for(int i = 1; i <= b; i++)
    {
        st *=a;
    }
    return $"{a}^{b}={st}";
}
try
{
    Console.WriteLine(Stepen());
}
catch
{
    Console.WriteLine("Необходимо ввести именно число");
}