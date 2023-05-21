// See https://aka.ms/new-console-template for more information
System.Console.Write("введите какое-нибудь целое число: ");
int num = Convert.ToInt32 (Console.ReadLine());

for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i+ ", ");
        }
    }