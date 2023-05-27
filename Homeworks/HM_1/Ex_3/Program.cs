// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int remainder = num % 2;
if (remainder == 0)
{
    Console.WriteLine("это четное число");
}
else
{
    Console.WriteLine("это не четное число");
}
