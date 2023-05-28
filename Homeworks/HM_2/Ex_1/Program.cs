// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Через строку решать нельзя.
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int x2 = num%100/10;

System.Console.WriteLine($"{x2}");