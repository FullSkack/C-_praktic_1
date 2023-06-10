// Функция выводит массив из 8 лементов случайного набора 0 и 1
int[] array = new int[8]; // задаем колличесвто эллементов массива

void FillArray(int[] collection) // Объявляем метод и переменные для работы
{
    int length = collection.Length;
    int index = 0;

    while (index < length) // цикл перебора и присвоения случайного значения элементу
    {
        collection[index] = new Random().Next(0, 2);
        index ++;
    }
}

void PrintArray(int[] massiv) // Объявляем метод и переменные для работы
{
    int count = massiv.Length;
    int position = 0;

    while (position < count) // цикл перебора и вывода в консоль соответсвующего элемента
    {
        Console.Write($"{massiv[position]}; "); // вывод с разделителем
        position ++;
    }
}

bool OneZero(int[] massiv)
{
    int count = 0;
    for (int i=0; i<massiv.Length; i++)
    {
        if (massiv[i] == 0)
        count++;
        else
            continue;
    }

    bool flag = false;
    if(count>massiv.Length/2)
        flag = true;
    return flag;
}

Console.Clear();
FillArray(array);
PrintArray(array);
System.Console.WriteLine($"Нулей больше чем единиц - {OneZero(array)}");