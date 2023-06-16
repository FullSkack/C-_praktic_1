// Массив из 12 случайных элементов в интервале [-9;9]
// найдите сумму положительных чисел
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);      
    }
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

void FinSums(int[] array)
{
    int sumP = 0; // сумма положительных
    int sumN = 0; // сумма отрицательных
    foreach (var item in array)
        if (item>0)
            sumP += item;
        else
            sumN += item;
    System.Console.WriteLine($"Сумма отрицательных чисел: {sumN}");
    System.Console.WriteLine($"Сумма положительных чисел: {sumP}");
 }


Console.Clear();
System.Console.Write("введите размерность: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
FinSums(array);
