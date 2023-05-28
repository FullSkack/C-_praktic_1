// Напишите программу, которая будет 
//принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.Clear();

Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());

if (x2%x1 == 0)
    Console.WriteLine($"{x2} кратно {x1}");
else
    Console.WriteLine(x2%x1);