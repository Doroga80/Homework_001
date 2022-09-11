//Напишите программу, которая найдет точку пересечения двух прямых
//заданных уровнениями y=k1*x=b1, y=k2*x=b2; значения b1, k1, b2, и
//k2 задаются пользователем.

string PointInterLines()
{
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    double x = Math.Round((-(b1 - b2) / (k1 - k2)), 3);
    double y = Math.Round((k1 * x + b1), 3);

    return $"Точка пересечения прямых имеет координаты : (x:{x},y:{y})";
}
try 
{
    Console.WriteLine(PointInterLines());
}
catch
{
    Console.WriteLine("error");
}
