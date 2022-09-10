// Программа, которая выводит третью цифру заданного числа
//или сообщает что третьей цыфры нет.

Console.WriteLine("Введите число:");
string x = Console.ReadLine();
int lngth= x.Length;
int x1=Convert.ToInt32(x);
int i =0;
if (lngth>2)
{
while (i<(lngth-3))
{
    x1=x1/10;
    i++;
}
Console.WriteLine("Третий знак в цифре равен:"+x1%10);
}
else
Console.WriteLine("Третьего знака нет");
