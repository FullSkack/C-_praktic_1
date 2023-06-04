// Программа принимает на вход координаты точки (x, y)
// x!=0 y!=0, программа выдаёт номер четверти плоскости точки
void CheckKoord(int x, int y) // процедура соверщающая действия над данными, ничего не возвращает
{
    if (x>0 && y>0)
        System.Console.WriteLine("Четветь #1");
    else if (x<0 && y>0)
        System.Console.WriteLine("Четветь #2");
    else if (x<0 && y<0)
        System.Console.WriteLine("Четветь #3");
    else if (x>0 && y<0)
        System.Console.WriteLine("Четветь #4");  
    else
        System.Console.WriteLine("Точка находится в начале координат");
}

Console.Clear();
System.Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

CheckKoord(x, y);

