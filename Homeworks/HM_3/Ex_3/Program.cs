// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void PrintCube(int N)
{
    int count = 1;

    while (count <= N)
    {
        int cube = count*count*count;
        System.Console.Write($"{cube}; ");
        count ++;
    }
    
}

Console.Clear();
System.Console.Write("Здайте целое положительное число: ");

int N = Convert.ToInt32(Console.ReadLine());

PrintCube(N);
