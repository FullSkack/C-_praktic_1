﻿// Массив из 12 случайных элементов в интервале [-9;9]
// найдите сумму положительных чисел

// метод наполняющий массив случайными цифрами
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);      
    }
}

// метод вывода массива в терминал
void PrintArray(int[] array)
{
    // цикл перебора всех элементов без индекса 
    foreach (var item in array)
    {
        System.Console.Write($"{item};");
    }
    System.Console.WriteLine();
}

// метод определяющий сумму положительных и отрицательных чисел
void FinSums(int[] array)
{
    int sumP = 0; // сумма положительных
    int sumN = 0; // сумма отрицательных
    foreach (var item in array)
        if (item>0)
            sumP += item;
        else
            sumN += item;
    System.Console.WriteLine($"Сумма отрицательных чисел: {sumN}");
    System.Console.WriteLine($"Сумма положительных чисел: {sumP}");
 }

 // метод определяющий сумму положительных и отрицательных чисел V_2.0
int[] FinSums2(int[] array)
{
    int sumP = 0; // сумма положительных
    int sumN = 0; // сумма отрицательных

    foreach (var item in array)
        if (item>0)
            sumP += item;
        else
            sumN += item;
    int[] result = {sumN, sumP}; // в переменную result записываем массив
    return result;

}

Console.Clear();
System.Console.Write("введите размерность: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

// вызываем метод FinSums2 через метод PrintArray 
FillArray(array);
PrintArray(array);
FinSums(array);
PrintArray(FinSums2(array)); 


