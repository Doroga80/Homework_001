void RandmCoordinates()
{
Console.WriteLine("Введите размерность плоскости: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int[] b = new int[n];
Console.WriteLine($"Координаты точки A:");
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(-100,101 );
    if (i < a.Length - 1) Console.Write($"{a[i]}, ");
    else Console.WriteLine($"{a[i]}");
}
Console.WriteLine($"Координаты точки B:");
for (int j = 0; j < a.Length; j++)
{
    b[j] = new Random().Next(-100,101);
    if (j < b.Length - 1) Console.Write($"{b[j]}, ");
    else Console.WriteLine($"{b[j]}");
}
double sum = 0;
for (int x = 0; x < n; x++)
{
    sum = sum + Math.Pow((a[x] - b[x]), 2);
}
double dist = Math.Round(Math.Sqrt(sum), 2);
Console.WriteLine($"Расстояние между точками составляет {dist}");
}


void IntroCoordinates()
{
    Console.WriteLine("Введите размерность плоскости: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int[] b = new int[n];
int z=1;  
int y=1;             // счетчик для координат
Console.WriteLine($"Координаты точки A: ");
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"Введите координату {z}: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
    z++;
}
Console.WriteLine($"Координаты точки B:");
for (int j = 0; j < a.Length; j++)
{
    Console.Write($"Введите координату {y}: ");
    b[j] = Convert.ToInt32(Console.ReadLine());
    y++;
}
double sum = 0;
for (int x = 0; x < n; x++)
{
    sum = sum + Math.Pow((a[x] - b[x]), 2);
}
double dist = Math.Round(Math.Sqrt(sum), 2);
Console.WriteLine($"Расстояние между точками составляет {dist}");
}

RandmCoordinates();
IntroCoordinates();void RandmCoordinates()
{
Console.WriteLine("Введите размерность плоскости: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int[] b = new int[n];
Console.WriteLine($"Координаты точки A:");
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(-100,101 );
    if (i < a.Length - 1) Console.Write($"{a[i]}, ");
    else Console.WriteLine($"{a[i]}");
}
Console.WriteLine($"Координаты точки B:");
for (int j = 0; j < a.Length; j++)
{
    b[j] = new Random().Next(-100,101);
    if (j < b.Length - 1) Console.Write($"{b[j]}, ");
    else Console.WriteLine($"{b[j]}");
}
double sum = 0;
for (int x = 0; x < n; x++)
{
    sum = sum + Math.Pow((a[x] - b[x]), 2);
}
double dist = Math.Round(Math.Sqrt(sum), 2);
Console.WriteLine($"Расстояние между точками составляет {dist}");
}


void IntroCoordinates()
{
    Console.WriteLine("Введите размерность плоскости: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int[] b = new int[n];
int z=1;  
int y=1;             // счетчик для координат
Console.WriteLine($"Координаты точки A: ");
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"Введите координату {z}: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
    z++;
}
Console.WriteLine($"Координаты точки B:");
for (int j = 0; j < a.Length; j++)
{
    Console.Write($"Введите координату {y}: ");
    b[j] = Convert.ToInt32(Console.ReadLine());
    y++;
}
double sum = 0;
for (int x = 0; x < n; x++)
{
    sum = sum + Math.Pow((a[x] - b[x]), 2);
}
double dist = Math.Round(Math.Sqrt(sum), 2);
Console.WriteLine($"Расстояние между точками составляет {dist}");
}

RandmCoordinates();
IntroCoordinates();
