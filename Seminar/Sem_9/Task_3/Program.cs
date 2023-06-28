// Программа выводит значени от M до N 
// Программа выводит значения от 1 до N

string GetNumbers(int n, int m)
// реализация через бесконечный цикл
{
    string str = "";
    while (true)
    {
        str = Convert.ToString(n) + ";" + str;
        n--;
        if (n==m)
            //str = Convert.ToString(n) + ";" + str;
            break;
    }
    return str;
}

// реализация через рекурсию
string GetNumbersRec(int n, int m)
{
    if (n == m) return $"{m};";
    return GetNumbersRec(n - 1, m) + n + ";" ;
    // когда идёт вызов самой себя, берем только
    // следующее n, показатель m остаётся неизменным    
}

Console.Clear();

System.Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(GetNumbers(n,m));
System.Console.WriteLine(GetNumbersRec(n,m));