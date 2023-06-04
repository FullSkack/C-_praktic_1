// по номеру четверти выдать диапазон значений
void Range(int quart) // процедура соверщающая действия над данными, ничего не возвращает
{
    if (quart == 1)
        System.Console.WriteLine("x > 0, y > 0");
    else if (quart == 2)
        System.Console.WriteLine("x < 0, y > 0");
    else if (quart == 3)
        System.Console.WriteLine("x < 0, y < 0");
    else if (quart == 4)
        System.Console.WriteLine("x > 0, y < 0");  
    else
        System.Console.WriteLine("Некоректное значение, введие 1,2,3 или 4");
}

Console.Clear();
System.Console.Write("Введите номер координатной четверти: ");
int quart = Convert.ToInt32(Console.ReadLine());

Range(quart);


