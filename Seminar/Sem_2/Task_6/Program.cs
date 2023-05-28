// Написать программу, которая принимает два чилса и проверяет, 
// являются ли они квадратми друг дурга
Console.Clear();
Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());

if (x1 == x2*x2 || x2 == x1*x1)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("Нет");