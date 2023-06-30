// See https://aka.ms/new-console-template for more information

int Summa(int num)
// реализация через бесконечный цикл
{
    int sum = 0;
    while (true)
    {
        sum += num % 10;
        num /= 10;
        if (num == 0)
            break;
    }
    return sum;
}

int SummRec(int num)
// реализация через рекурсию
{
    if(num == 0) return 0;
    return num % 10 + SummRec(num / 10);
}

Console.Clear();
System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма цифр числа = {Summa(num)};");
System.Console.WriteLine($"Сумма цифр числа = {SummRec(num)};");