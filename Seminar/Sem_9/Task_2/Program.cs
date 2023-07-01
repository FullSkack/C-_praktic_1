// Программа выводит значения от 1 до N

string GetNumbers(int num)
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

string GetNumbersRec(int n)
{
    if (n == 0)  return "";
    return GetNumbersRec(n - 1) + n + ";" ;    
}

Console.Clear();

System.Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetNumbers(n));
System.Console.WriteLine(GetNumbersRec(n));
