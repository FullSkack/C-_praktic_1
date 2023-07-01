// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
int SumRec(int n, int m)
{
    if(n == m) return m;
    return n + SumRec (n - 1, m);
}

Console.Clear();

System.Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumRec(n,m));
