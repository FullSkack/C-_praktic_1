// Функция принимает на вход число N выводит произведение от 1 до N
int Factorial(int num)
{   
    int result = 1;
    for (int i=1; i<=num; i++)
        result*=i;
    return result;
}


Console.Clear();
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Факториал N = {Factorial(num)}");


