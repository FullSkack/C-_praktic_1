// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. И  
// найти отдельно сумму элементов обратной диагонали.

void FillArray(int[,] array)
// метод заполняющий массив случайными целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-9,10);
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

int[] TraceArray(int[,] array)
// метод определения суссмы на диагоналаях
{
    int[] summ = {0, 0}; // переменная суммы
    
    // цикл переирающийэлементы массива
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            {
            
            if (i==j)
            // Ветка цикла суммируящая элементы главной диагонали
            {
                summ[0] = summ[0] + array[i,j];
            }
            // Ветка цикла суммируящая элементы обратной4 диагонали
            if (i == array.GetLength(1)-j-1)
            {
                summ[1] = summ[1] + array[i,j];
            }
        }
        }
    return summ;
}


Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int[] summ = TraceArray(array);
System.Console.WriteLine($"{summ[0]}, {summ[1]}");