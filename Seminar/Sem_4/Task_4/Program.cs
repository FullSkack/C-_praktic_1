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
        Console.Write(massiv[position]);
        position ++;
    }
}

FillArray(array);
PrintArray(array);