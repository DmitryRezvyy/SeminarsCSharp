﻿//Задача №54 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine("Укажите размер массива");
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt16(Console.ReadLine());
int[,] Create2DimArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = new Random().Next(101);
        }
    }
    return newArray;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] SortMaxToMinElementsInRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            max = array[i, j];
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] <= array[i, k])
                {
                    max = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = max;                    
                }
            }
        }
    }
    return array;
}
int[,] myArray = Create2DimArray(rows, columns);
PrintArray(myArray);
myArray = SortMaxToMinElementsInRows(myArray);
PrintArray(myArray);
*/

//Задача №56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Укажите размер массива: ");
int size = Convert.ToInt16(Console.ReadLine());
int[,] Create2DimArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = new Random().Next(101);
        }
    }
    return newArray;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MinSumRowNumber(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = sum[i] + array[i, j];
        }
    }
    for (int t = 0; t < sum.Length; t++)
    {
        Console.Write(sum[t] + " ");
    }
    int rowNumber = Array.IndexOf(sum, sum.Min());
    return rowNumber + 1;
}
int[,] myArray = Create2DimArray(size, size);
PrintArray(myArray);
Console.WriteLine($"Строка с минимальной суммой элементов: {MinSumRowNumber(myArray)} строка");