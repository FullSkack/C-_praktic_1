// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
﻿Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;

if (count < 3)
{
    Console.Write("Третьей цифры нет");
}

else
{
    int MakeArray(int a, int b)
    {
    int result = 0;
    int c = 1;
        for (int i = b; i > 3; i--)
        {
             c = c * 10;
        }
        result = (a/c) % 10;
    return result;    
    }
    Console.Write(MakeArray(number, count));
    
}
