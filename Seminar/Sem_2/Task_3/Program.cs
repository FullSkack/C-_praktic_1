// Выводит случайное трехзначное число и удаляет 2-ю цифру этого числа
Console.Clear();
int num = new Random().Next(100, 1000); // ниржняя граница входит, верхняя не входит
System.Console.WriteLine($"Было сгенерированно число {num}");

int x1 = num/100;
int x3 = num%10;

System.Console.WriteLine($"{x1}{x3}");