// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// Метод проверяющий вхождение числа в массив
void FindNumberInArray(int[] array, int num)
{
    bool Find = false; // флаг булевой переменной со значением по умолчанию
    foreach (var item in array)
    {
        // вестка, если число входит в массив
        if (item == num) 
        {
            System.Console.WriteLine("Да");
            Find = true;
            break;
        }
    }
    // вестка, если число не входит в массив,
    // вынесена из цикла foreach, что бы не дублироваться при проходке
    if (Find == false) System.Console.WriteLine("Нет");
}

// метод заполения массива случайными элементами
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}

// метод вывода массива в терминал
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

// Задаем входные переменные
System.Console.Write("Введите диапазаон массива: ");
int size = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

// создаем массив
int[] Array = new int[size];

// вызов функций с заданными переменными
FillArray(Array);
PrintArray(Array);
FindNumberInArray(Array, num);