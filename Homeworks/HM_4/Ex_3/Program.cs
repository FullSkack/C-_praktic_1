// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];

void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;

    while (index < length) 
    {
        collection[index] = new Random().Next(0, 9);
        index ++;
    }
}

void PrintArray(int[] massiv)
{
    int count = massiv.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write($"{massiv[position]}; ");
        position ++;
    }
}

Console.Clear();
FillArray(array);
PrintArray(array);