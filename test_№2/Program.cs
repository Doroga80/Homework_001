//Программа, которая на вход принимает двачисла и выдает, каеое
//число больше, а какое меньше.

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
 
if(a>b)
{
    Console.WriteLine("max=" + a);
}
else if(a<b)
{
    Console.WriteLine("max=" + b);
}