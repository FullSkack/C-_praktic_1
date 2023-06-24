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

void PrintEl(int[,] array, int num)
// метод работающий с элементом массива
{   
    string pos = "";
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        if (array [i,j] == num)
            pos = $"позиция числа - {i},{j};";
        else
            pos = "такого числа в массиве нет;";
    System.Console.WriteLine(pos);
}

Console.Clear();
System.Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов");
int cals = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows, cals]; // создаем двумерный массив

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray(array);
PrintEl(array, num);
