// Функция на вход принимает N, выдает сумму от 1 до N
int Summ(int num)
{
    int result = 0;
    for (int i=1; i<=num; i++)
        result+=i;
    return result;
}

Console.Clear();
System.Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма чисел от 1 до {num} равна {Summ(num)}");