// See https://aka.ms/new-console-template for more information
Console.Write("введите первое число: ");
int number_1 = int.Parse(Console.ReadLine())!;
Console.Write("введите первое число: ");
int number_2 = int.Parse(Console.ReadLine())!;
if (number_1 == number_2 * number_2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}