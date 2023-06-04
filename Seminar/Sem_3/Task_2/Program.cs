// See https://aka.ms/new-console-template for more information
int CheckKoord_2(int x, int y) // функция 
{
    int result =0;

    if (x>0 && y>0)
        result = 1;
    else if (x<0 && y>0)
        result = 2;
    else if (x<0 && y<0)
        result = 3;
    else if (x>0 && y<0)
        result = 4;    
    return result; 

}

Console.Clear();
System.Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"это четверть #{CheckKoord_2(x,y)}");