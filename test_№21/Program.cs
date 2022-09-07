//Программа, которая принимает на вход координаты двух точек
//и находит расстояние между ними.
string Distance()
{
    Console.WriteLine("Введите координату x точка A:");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y точка A:");
    int ya = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z точка A:");
    int za = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату x точка B:");
    int xb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату x точка B:");
    int yb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату x точка B:");
    int zb = Convert.ToInt32(Console.ReadLine());
    double sum = Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2);
    double dist = Math.Round(Math.Sqrt(sum), 2);
    return $"Расстояние между точками составляет {dist}";
}

try
{
    Console.WriteLine(Distance());
}
catch 

{
    Console.WriteLine("Необходимо ввести именно числа");
    //throw;
}
