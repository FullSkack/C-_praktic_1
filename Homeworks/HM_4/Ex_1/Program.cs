// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число A = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B = ");
double b = Convert.ToDouble(Console.ReadLine());
double c = 1;
if (b<1)
Console.Write("Число B должно быть натуральным");
else
{
    while (b != 0)
    {
        c = Math.Pow(a, b);
        break;
        
    }
Console.Write($"A^B = {c}");
}