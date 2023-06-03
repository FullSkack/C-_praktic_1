// See https://aka.ms/new-console-template for more information
Console.Write("введите число от 1 до 7, что бы узнать день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Понедельник");
} 
if (number == 2)
{
    Console.WriteLine("Вторник");
} 
if (number == 3)
{
    Console.WriteLine("Среда");
}
if (number == 4)
{
    Console.WriteLine("Четверг");
}
if (number == 5)
{
    Console.WriteLine("Пятница");
}
if (number == 6)
{
    Console.WriteLine("Суббота");
}
if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("введите число от 1 до 7");
}