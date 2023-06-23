// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса нечётные, и замените эти элементы 
// на их квадраты.

void FillArray(int[,] array)
// метод заполняющий массив
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-9,10);
}

void PrintArray(int[,] array)
// метод печтающий массив
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void ReplaceArray(int[,] array)
// метод меняющий значения в массиве
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            // ветвленение для замены числе в массиве 
            // и проверки не четности индекса
            if (i%2!=0 && j%2!=0)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
}



Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);

ReplaceArray(array);
PrintArray(array);
