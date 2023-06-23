// Задайте двумерный массив rows x cals, 
// заполненный случайными целыми числами

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
            System.Console.Write($"{array[i,j]};");
        System.Console.WriteLine();
        }
}

Console.Clear();
System.Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов");
int cals = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows, cals]; // создаем двумерный массив

FillArray(array);
PrintArray(array);
