// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b )
{
  Console.WriteLine($"max = {a}");
  Console.WriteLine($"min = {b}");
}
else
{
  Console.WriteLine($"max = {b}");
  Console.WriteLine($"min = {a}");
}