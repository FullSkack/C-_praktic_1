﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
Console.Clear();
int num = new Random().Next(10, 100); // генерация случайного числа в промежутке [...]
System.Console.WriteLine($"Было сгенерированно число {num}");
int x1 = num/10; // получаем 1ю цифру тк дкление целочисленное
int x2 = num/100; // получаем 2ю цифру тк дкление целочисленное
if (x1>x2)
    System.Console.WriteLine($"Наибольшаяя цифра числа {x1}");
else if (x1<x2)
    System.Console.WriteLine($"Наибольшаяя цифра числа {x2}");
else
    System.Console.WriteLine($"Обе цифры одинаковые");