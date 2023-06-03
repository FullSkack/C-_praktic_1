// Программа принимает на вход координаты точки (x, y)
// x!=0 y!=0, программа выдаёт номер четверти плоскости точки
Console.Clear();
System.Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
    System.Console.WriteLine("Четветь #1");
if (x<0 && y>0)
    System.Console.WriteLine("Четветь #2");
if (x<0 && y<0)
    System.Console.WriteLine("Четветь #3");
if (x>0 && y<0)
    System.Console.WriteLine("Четветь #4");  
