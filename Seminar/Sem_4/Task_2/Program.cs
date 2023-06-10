// Функция принимает число и выдает сколько в нем цифр
int DoubleToInt(decimal num) 
// необязательная часть с дробными числами не работает до конца
{
    while (num%1 != 0)
    {
        num*=10;
    }
    return Convert.ToInt32(num);

}

int CountNum(int num)
// обязательная часть, всё работает
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

Console.Clear();
System.Console.Write("Введите число: ");
decimal num = Convert.ToInt32(Console.ReadLine());

int temp = 0;
temp = DoubleToInt(num);

System.Console.WriteLine($"Колличество Цифр - {CountNum(temp)}");