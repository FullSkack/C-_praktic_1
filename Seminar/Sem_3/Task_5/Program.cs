// Принимает на вход любое число и выдает квадтраты от 1 до N
void PrintSqrt(int N)
{
    int count = 1;

    while (count <= N)
    {
        int sqrt = count*count;
        System.Console.Write($"{sqrt}; ");
        count ++;
    }
    
}

Console.Clear();
System.Console.Write("Здайте целое положительное число: ");

int N = Convert.ToInt32(Console.ReadLine());

PrintSqrt(N);

