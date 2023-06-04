// Программа принимает координаты двух точек и находт расстояние между ними.
double Lengh(double x1, double y1, double x2, double y2)
{
    double result = Math.Round(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)), 2);
    return result;
}

System.Console.Write("Введите x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
 
System.Console.WriteLine($"Длина отрезка = {Lengh(x1, y1, x2, y2)}");