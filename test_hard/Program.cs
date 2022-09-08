//Программа, которая считывает с консоли (по одному в строке) до тех пор плока
// сумма введенных чисел не будет ровна 0 и сразу после этого выводит сумму 
// квадратов всех чисел. Гарантируется что в какой то моиент сумма введенных чисел
// будет ровна 0, после этого считывания продолжать не нужно.
string Sum_Square()
{
    int[] myarray = new int[10];
    Console.WriteLine("Введите число: ");
    for(int j=0; j< myarray.Length; j++)
    {
        myarray[j] = Convert.ToInt32(Console.ReadLine());
    }
    int sum = 0;
    int sum_square = 0;
    int i = 0;
    while(true)
    {
        sum += myarray[i];
        sum_square += myarray[i] * myarray[i];
        if(sum == 0)
        {
            return $"Сумма квадратов чисел равна :{sum_square}";
            break;
        }
        i++;
    }
}
try
{
    Console.WriteLine(Sum_Square());
}
catch 

{
    Console.WriteLine("Необходимо ввести именно число");
    //throw;
}