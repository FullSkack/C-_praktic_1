// принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Через строку решать нельзя.
void CheckPolindrom(int num)
{
    int num_1 = num / 1000;

    int num_2 = num % 100;
    string num_str = num_2.ToString();
    char[] num_ar = num_str.ToCharArray();
    Array.Reverse(num_ar);
    num_str = new String(num_ar);
    num_2 = Convert.ToInt32(num_str);

    
    if (num>999 && num<100000 && num_1 == num_2)
        System.Console.WriteLine("полиндром");
    else if (num>999 && num<100000 && num_1 != num_2)
        System.Console.WriteLine("не полиндром");        
    else
        System.Console.WriteLine("Некорректное значение, введите пятизначное число");
}

Console.Clear();
System.Console.Write("Введите петизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

CheckPolindrom(num);
