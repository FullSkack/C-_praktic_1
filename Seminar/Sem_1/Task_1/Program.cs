// Напишите программу, которая на въоди принимает число и выдаёт его квадрат.
Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"{number} -> {sqr}");