// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.


string GetNumbersRec(int n)
{
        if (n == 0) return "";
        return GetNumbersRec(n - 1) + n + " ";
}

string Reverse( string PareRes )
{
    char[] charArray = PareRes.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

Console.Clear();

System.Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
string PareRes = GetNumbersRec(n);
System.Console.WriteLine(Reverse(PareRes));