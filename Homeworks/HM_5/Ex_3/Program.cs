// Задайте массив вещественных случайных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void MinMax(int[] array)
{
    int max = 0;
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            {
                max = array[i];
            }
        else if (array[i] < min)
            {
                min = array[i];
            }
    }
    System.Console.WriteLine($"MAX = {max}");
    System.Console.WriteLine($"MIN = {min}");
    System.Console.WriteLine($"MAX - MIN = {max - min}");
}

Console.Clear(); 
System.Console.Write("Введите диапазон массива: "); 
int size = Convert.ToInt32(System.Console.ReadLine()); 

int[] array = new int[size]; 

FillArray(array);
MinMax(array);