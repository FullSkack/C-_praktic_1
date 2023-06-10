// Функция принимает число и выдает сколько в нем цифр
int CountNum(int num)
{
    int count = 0;
    while (num > 0)
    {
        num/=10;
        count++;
    }
    return count;
}

Console.Clear();
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Колличество Цифр - {CountNum(num)}");