// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("введите какое-нибудь целое число");
int num = Convert.ToInt32 (Console.ReadLine());
int count = -num;

while (count<=num)
{
    System.Console.Write(count+ ", ");
    count++;
}
