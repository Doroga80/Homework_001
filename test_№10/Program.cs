//Программа, которая принимает на вход трехзначное число
//или сооющает, что третей цыфры нет.

void SecondDigit()
{
    Console.WriteLine("Введите трехзначное число:");
    int x = Convert.ToInt32(Console.ReadLine());
    int x1 = x / 10;
    int y = x1 % 10;
    Console.WriteLine("Второй знак в числе равен:" + y);
}

SecondDigit();
