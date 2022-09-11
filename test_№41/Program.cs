//Пользователь вводит с клавиатуры M чисел. Посчитать сколько
//чисел больще 0 ввел пользователь.

string ElementsGreatZero()
{
Console.WriteLine("Введите элементы через пробел: ");
int[] num = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
uint count = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        count++;
    }
}
return $"Количество элементов больше нуля равно {count}";
}

try
{
    Console.WriteLine(ElementsGreatZero());
}
catch
{
    Console.WriteLine(" error");
}

