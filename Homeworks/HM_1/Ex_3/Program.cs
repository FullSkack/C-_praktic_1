// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int numString = int.Parse(Console.ReadLine());
decimal numDouble = Convert.ToDecimal(numString);
decimal remainder = numDouble % 2;
if (remainder == 0)
{
    Console.WriteLine("это четное число");
}
else
{
    Console.WriteLine("это не четное число");
}