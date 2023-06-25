﻿// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();

System.Console.WriteLine("Введите количество строк 1-й матрицы");
int rows_1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов 1-й матрицы");
int cols_1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество строк 2-й матрицы");
int rows_2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов 2-й матрицы");
int cols_2 = Convert.ToInt32(Console.ReadLine());

int[,] FirstMatrix = new int [rows_1, cols_1];
FillArray(FirstMatrix);
System.Console.WriteLine("Первая матрица");
PrintArray(FirstMatrix);

int[,] SecondMatrix = new int [rows_2, cols_2];
FillArray(SecondMatrix);
System.Console.WriteLine("Вторая матрица");
PrintArray(SecondMatrix);

int[,] ResultMatrix = new int [rows_1, cols_2];
MultiplyMatrix(FirstMatrix, SecondMatrix, ResultMatrix);
System.Console.WriteLine("Произведение матриц");
PrintArray(ResultMatrix);

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

void MultiplyMatrix(int[,] FirstMatrix, int[,] SecondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < FirstMatrix.GetLength(1); k++)
            {
                sum += FirstMatrix[i,k] * SecondMatrix[k,j];
            }
            ResultMatrix[i,j] = sum;
        }
    }
}

