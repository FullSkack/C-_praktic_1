// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

void FillArray (double[,] array)
// метод заполняющий массив случайными вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().NextDouble();
}

void PrintArray(double[,] array)
// метод печатающий массив из случайных чисел
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i,j],3};  ");
        System.Console.WriteLine();
        }
}

Console.Clear();
System.Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов");
int cals = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, cals]; // создаем двумерный массив

FillArray(array);
PrintArray(array);
