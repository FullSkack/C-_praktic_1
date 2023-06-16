// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,9);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item};");
    }
    System.Console.WriteLine();
}

int Summ(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Clear(); 
System.Console.Write("Введите диапазон массива: "); 
int size = Convert.ToInt32(System.Console.ReadLine()); 

int[] array = new int[size]; 

FillArray(array); 
PrintArray(array);

int Sum = Summ(array);
System.Console.WriteLine(Sum);
