// Пользователь вводит число, программа 
// проверяет кратно ли оно одновременно 7 и 23
Console.Clear();
System.Console.Write($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%7==0 && num%23 == 0)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("Нет");