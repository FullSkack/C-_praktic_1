﻿// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item};");
    }
    System.Console.WriteLine();
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Clear(); 
System.Console.Write("Введите диапазон массива: "); 
int size = Convert.ToInt32(System.Console.ReadLine()); 

int[] array = new int[size]; 

FillArray(array); 
PrintArray(array);
System.Console.WriteLine(Count(array));