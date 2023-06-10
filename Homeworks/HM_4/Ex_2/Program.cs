// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int CountNum(int num)
{
    if(num == 0) return 1;

    int count = 0;
    while (num != 0)
    {
        num/=10;
        count++;
    }
    return count;
}

int SumNum(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Clear();
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int len = CountNum(num);
System.Console.WriteLine($"Сумма цифр числа равна = {SumNum(num,len)}");