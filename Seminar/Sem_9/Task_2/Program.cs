// Программа выводит значения от 1 до N

string GetNumbers(int n)
// реализация через бесконечный цикл
{
    string str = "";
    while (true)
    {
        str = Convert.ToString(n) + ";" + str;
        n--;
        if (n==0)
            break;
    }
    return str;
}

// реализация через рекурсию
string GetNumbersRec(int n)
{
    if (n == 0)  return "";
    return GetNumbersRec(n - 1) + n + ";" ;    
}

Console.Clear();

System.Console.WriteLine("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetNumbers(n));
System.Console.WriteLine(GetNumbersRec(n));
