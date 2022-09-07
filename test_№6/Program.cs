//Программа, которая на вход принимает число и выдает, являеься
//ли число четным(делтся ли оно на два без остатка).

Console.WriteLine("Введите чмсло a:");
int a = Convert.ToInt32(Console.ReadLine());

if((a%2)==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}
