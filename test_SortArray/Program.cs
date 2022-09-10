
Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
int lngth = numbers.Length;
Console.WriteLine("Изначальный массив:");
for (int i = 0; i < lngth; i++)
{
    numbers[i] = new Random().Next(0, 100);
    if (i != numbers.Length - 1) Console.Write($"{numbers[i]}, ");
    else Console.WriteLine($"{numbers[i]}");
}


int temp;
for (int i = 0; i < lngth - 1; i++)
{
    for (int j = i + 1; j < lngth; j++)
    {
        if (numbers[i] < numbers[j])
        {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
Console.WriteLine("Отсортированный массив:");
for (int j = 0; j < lngth; j++)
{
    if (j != numbers.Length - 1) Console.Write($"{numbers[j]}, ");
        else Console.WriteLine($"{numbers[j]}");
}


int mid = (lngth / 2);
int median = 0;
if (lngth % 2 == 0)
{
    median = (numbers[mid] + numbers[mid - 1]) / 2;
}
else
{
    median = numbers[mid];
}
Console.WriteLine($"Медиана = {median}");
