// Задайте двумерный массив из целых чисел
// Найдите среднее арифметическое элементов в каждом столбце.

void FillArray (int[,] array)
// метод заполняющий массив случайными целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30,31);
}

void PrintArray(int[,] array)
// метод печатающий массив из случайных чисел
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void AvgNum(int[,] array)
// метод определяющий среднее арифметическое.
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum/array.GetLength(0)};");
    }
}



Console.Clear();
System.Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов");
int cals = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows, cals];

FillArray(array);
PrintArray(array);
AvgNum(array);

