﻿//Задайте массив заполненный случайными положительными трехзначными числами.
//Напишите программу которая показывает количество четных чисел в масиве>

int[] PrintArray()
{
    Console.WriteLine("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] num = new int [n];
    for (int i = 0; i <num.Length; i++)
    {
        num[i] = new Random().Next(100, 1000);
        if(i < (num.Length - 1)) Console.Write($"{num[i]}, ");
        else Console.WriteLine($"{num[i]} ");
    }
    return num;
}
string EvenNum(int[] array)
{
    int count = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if(array[j] % 2 == 0)
           count++;
    }
    return $"Количество четных элементов = {count}";
}
try
{
    int[] mas = PrintArray();
    Console.WriteLine(EvenNum(mas));
}
catch

{
    
    Console.WriteLine("error");
}
