// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. 

// метод заполняющий массив случайными числами
void FillArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = new Random().Next(-100, 101); 
    } 
} 
 
// метод выводящий массив в терминал
void PrintArray(int[] array) 
{ 
    foreach (var item in array) 
    { 
        System.Console.Write($"{item} "); 
    } 
    System.Console.WriteLine(); 
} 
 
// метод производящий произведение крайних элементов и записывающий новый массив 
void MultArray (int[] array, int [] arrayMult) // переменный новый и старый массив 
{ 
    int size = array.Length/2; // значение длины нового массива по умолчанию 
    // Цикл перемножающий крайние элементы между собой
    for (int i = 0; i < size; i++) 
    { 
        arrayMult[i] = array[i] * array[array.Length-1-i]; 
    }
    // ветвление определения последнего элемента нового массива, 
    // если началиный массив нечетный 
    if (size%2==1) 
        arrayMult[arrayMult.Length-1] = array[array.Length/2]; 
    System.Console.WriteLine(); 
} 

//метод производящий произведение крайних элементов и записывающий новый массив 2.0
int[] Mult(int[] array)
{    
    // Объяляем в методе новый массив с нужной нам длинной
    // длинак новго массива определяется так,
    //если он не четный к ней прибавится нужный элемент
    int[] multArr = new int[array.Length / 2 + array.Length % 2];
    // Цикл перемножающий крайние элементы между собой
    for (int i = 0; i < array.Length / 2; i++)
    {
        multArr[i] = array[i] * array[array.Length - i - 1];
    }
    // ветвление определения последнего элемента нового массива, 
    // если началиный массив нечетный 
    if (array.Length % 2 != 0) multArr[^1] = array[multArr.Length - 1];
    return multArr;
}

 
 
 
Console.Clear(); 
System.Console.Write("Введите диапазон массива: "); 
int size = Convert.ToInt32(System.Console.ReadLine()); 
 
int[] array = new int[size]; 
int[] arrayMult = new int[size/2 + size%2]; 
 
FillArray(array); 
PrintArray(array); 
MultArray(array, arrayMult); 
PrintArray(arrayMult);
PrintArray(Mult(array));
