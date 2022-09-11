//На вход программы подаются три целых положительных числа.
//Определить, является ли это сторонами треугольника. Если да, то вывести всю информацию
//по нему - площадь, периметр, значение углов треугольника в градусах, является ли он
//прямоугольником, равнобедренным, равносторонним.

Console.Write("Введите число 1: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число 2: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число 3: ");
double num3 = Convert.ToDouble(Console.ReadLine());

if (num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1)
{
    if (num1 == num2 && num2 == num3)
    {
        double corner1 = 60;
        double corner2 = 60;
        double corner3 = 60;
        double area = Math.Round((Math.Pow(num1, 2) * Math.Sqrt(3) / 4), 2);
        double perimeter = num1 + num2 + num3;
        Console.WriteLine($"Треугольник является равносторонним");
        Console.WriteLine($"углол 1 = {corner1}, угол 2 = {corner2}, угол 3 = {corner3}");
        Console.WriteLine($"площадь треугольника = {area}");
        Console.WriteLine($"периметр треугольника = {perimeter}");

    }
    else if (num1 == num2 & num2 != num3 || num1 == num3 & num3 != num2 || num2 == num3 & num1 != num2)
    {
        if (num1 == num2)
        {
            double corner1 = Math.Round((Math.Cos(num3 / (num1 * 2)) * 180 / Math.PI), 2);
            double corner2 = Math.Round((Math.Cos(num3 / (num1 * 2)) * 180 / Math.PI), 2);
            double corner3 = 180 - (corner1 * 2);
            double area = Math.Round((num3 / 4 * Math.Sqrt(4 * num1 * num2 - num3 * num3)), 2);
            double perimeter = num1 + num2 + num3;
            Console.WriteLine($"Треугольник является равнобедренным");
            Console.WriteLine($"углол 1 = {corner1}, угол 2 = {corner2}, угол 3 = {corner3}");
            Console.WriteLine($"площадь треугольника = {area}");
            Console.WriteLine($"периметр треугольника = {perimeter}");
        }
        else if (num1 == num3)
        {
            double corner1 = Math.Round((Math.Cos(num2 / (num1 * 2)) * 180 / Math.PI), 2);
            double corner2 = Math.Round((Math.Cos(num2 / (num1 * 2)) * 180 / Math.PI), 2);
            double corner3 = 180 - (corner1 * 2);
            double area = Math.Round((num2 / 4 * Math.Sqrt(4 * num1 * num1 - num2 * num2)), 2);
            double perimeter = num1 + num2 + num3;
            Console.WriteLine($"Треугольник является равнобедренным");
            Console.WriteLine($"углол 1 = {corner1}, угол 2 = {corner2}, угол 3 = {corner3}");
            Console.WriteLine($"площадь треугольника = {area}");
            Console.WriteLine($"периметр треугольника = {perimeter}");
        }
        else if (num2 == num3)
        {
            double corner1 = Math.Round((Math.Cos(num1 / (num2 * 2)) * 180 / Math.PI), 2);
            double corner2 = Math.Round((Math.Cos(num1 / (num2 * 2)) * 180 / Math.PI), 2);
            double corner3 = 180 - (corner1 * 2);
            double area = Math.Round((num1 / 4 * Math.Sqrt(4 * num2 * num2 - num1 * num1)), 2);
            double perimeter = num1 + num2 + num3;
            Console.WriteLine($"Треугольник является равнобедренным");
            Console.WriteLine($"углол 1 = {corner1}, угол 2 = {corner2}, угол 3 = {corner3}");
            Console.WriteLine($"площадь треугольника = {area}");
            Console.WriteLine($"периметр треугольника = {perimeter}");
        }
    }
    else if (num1 * num1 + num2 * num2 == num3 * num3 || num1 * num1 + num3 * num3 == num2 * num2 || num3 * num3 + num2 * num2 == num1 * num1)
    {
        if (num1 * num1 + num2 * num2 == num3 * num3)
        {
            double corner1 = 90;
            double corner2 = Math.Round((Math.Cos(num2 / num3) * 180 / Math.PI), 2);
            double corner3 = 180 - corner1 - corner2;
            double area = Math.Round((num1 * num2 / 2), 2);
            double perimeter = num1 + num2 + num3;
            Console.WriteLine($"Треугольник является прямоугольным");
            Console.WriteLine($"углол 1 = {corner1}, угол 2 = {corner2}, угол 3 = {corner3}");
            Console.WriteLine($"площадь треугольника = {area}");
            Console.WriteLine($"периметр треугольника = {perimeter}");
        }
        else if (num1 * num1 + num3 * num3 == num2 * num2)
        {
            double corner1 = 90;
            double corner2 = Math.Round((Math.Cos(num3 / num2) * 180 / Math.PI), 2);
            double corner3 = 180 - corner1 - corner2;
            double area = Math.Round((num1 * num3 / 2), 2);
            double perimeter = num1 + num2 + num3;
            Console.WriteLine($"Треугольник является прямоугольным");
            Console.WriteLine($"углол 1 = {corner1}, угол 2 = {corner2}, угол 3 = {corner3}");
            Console.WriteLine($"площадь треугольника = {area}");
            Console.WriteLine($"периметр треугольника = {perimeter}");
        }
        else if (num3 * num3 + num2 * num2 == num1 * num1)
        {
            double corner1 = 90;
            double corner2 = Math.Round((Math.Cos(num2 / num1) * 180 / Math.PI), 2);
            double corner3 = 180 - corner1 - corner2;
            double area = Math.Round((num3 * num2 / 2), 2);
            double perimeter = num1 + num2 + num3;
            Console.WriteLine($"Треугольник является прямоугольным");
            Console.WriteLine($"углол 1 = {corner1}, угол 2 = {corner2}, угол 3 = {corner3}");
            Console.WriteLine($"площадь треугольника = {area}");
            Console.WriteLine($"периметр треугольника = {perimeter}");
        }
    }
}
else
{
    Console.WriteLine("Фигура не является треугольником");
}
