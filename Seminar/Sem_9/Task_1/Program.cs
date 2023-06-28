// Сумма чисел от 1 до n

int Sum(int n)
// функция через бесконечный цикл
{
    int sum = 0;
    while(true)
    {
        sum+= n;
        n--;
        if (n==0)
            break;
    }
    return sum;
}
// функция через рекурсию
int SumRec(int n)
{
    if(n == 0) return 0;
    return n + SumRec (n - 1);
}

Console.Clear();
System.Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма чисел от 1 до {n} = {Sum(n)}");
System.Console.WriteLine($"Сумма чисел от 1 до {n} = {SumRec(n)}");