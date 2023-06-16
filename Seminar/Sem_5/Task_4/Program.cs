// Задайте одномерный массив из 15 случайных чисел от -100 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Метод наполняющий массив случайными элементами
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,101);
    }
}

// Метод выводяший в терминал значения массива
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item};");
    }
    System.Console.WriteLine();
}

// Метод определяющий вхождение элемента в диапазон
int FindAndMemo(int[] array)
{
    int count = 0;
    // цикл перебирающий и суммирующий элементы
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >9 && array [i] < 100)
            count ++;
    }
    return count;
}

Console.Clear();

int[] array = new int[15]; // размерность была задана по умолчанию
FillArray(array);
PrintArray(array);
System.Console.WriteLine(FindAndMemo(array));
