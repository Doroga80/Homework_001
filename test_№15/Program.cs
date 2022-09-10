// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

void Days()
{
Console.WriteLine("Введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Ура! Выходной!");
}
if (day >= 1 && day <= 5)
{
    Console.WriteLine("Рабочий день");
}
if (day > 7)
{
    Console.WriteLine("Не верно введен номер дня");
}
}

Days();
