// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
Console.Clear();
int num = new Random().Next(10, 100);
System.Console.WriteLine($"Было сгенерированно число {num}");
int x1 = num/10;
int x2 = num/100;
if (x1>x2)
    System.Console.WriteLine($"Наибольшаяя цифра числа {x1}");
else if (x1<x2)
    System.Console.WriteLine($"Наибольшаяя цифра числа {x2}");
else
    System.Console.WriteLine($"Обе цифры одинаковые");