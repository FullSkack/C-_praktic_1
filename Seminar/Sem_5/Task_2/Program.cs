// Программа меняет положительные числа на соответвующие отрицательные и наоборот
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);      
    }
}

void Replace(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;      
    }
    System.Console.WriteLine();
}

void PrintArray(int[] array)
{
    // цикл перебора всех элементов без индекса 
    foreach (var item in array)
    {
        System.Console.Write($"{item};");
    }
    System.Console.WriteLine();
}

Console.Clear();
System.Console.Write("введите размерность: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);
Replace(array);
PrintArray(array);
