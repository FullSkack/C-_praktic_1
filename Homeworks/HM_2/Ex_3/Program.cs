// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.Write("Введите цифру от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
    System.Console.WriteLine("Да");
else if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
    System.Console.WriteLine("Нет");
else
    System.Console.WriteLine("Неверные параметы. Введите цифру от 1 до 7: ");