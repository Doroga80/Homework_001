//Программа, которая принимает на вход число (N) и выдает таблицу кубов 
//чисел от 1 до N.
void CubeTable()
{
    Console.WriteLine("Введите число n:");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i=1; i<=n; i++)
    {
        Console.WriteLine($"{i*i*i}, ");
    }
}    

try
{
    CubeTable();
}
catch
{
    Console.WriteLine("Необходимо вводить именно число");
}

