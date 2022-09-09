//Программа, которая задает массив из 8 элементов
//и выводит их на зкран.
void PrintArray()
{
    int[] numbers = new int[8];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 100 );
    
        Console.Write($"{numbers[i]}, ");    
            
    }
    // Console.WriteLine();
}

PrintArray();