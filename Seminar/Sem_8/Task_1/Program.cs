void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30,31);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    "); 
        System.Console.WriteLine();
        }
}

void Transponirovanie(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = i; j < array.GetLength(1); j++)
    {
        int temp = array[i,j]; // здесь можно было сделать множетвенное присваивание
        array[i,j] = array[j, i];
        array [j,i] = temp;

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
System.Console.WriteLine();
if (array.GetLength(0) == array.GetLength(1))
{
    Transponirovanie(array);
    PrintArray(array);
}
else 
{
    System.Console.WriteLine("Матрица не квадратная");
}
