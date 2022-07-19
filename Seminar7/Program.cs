//Задача №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.WriteLine("Укажите размер массива");
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] Create2DimArray(int m, int n)
{
double[,] newArray = new double [m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        newArray[i, j] = Math.Round(new Random().NextDouble() * (new Random().Next(101)), 2);
    }
}
return newArray;
}
void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
double[,] myArray = Create2DimArray(rows, columns);
PrintArray(myArray);
*/

//Задача №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();
int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
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
}

int[,] myArray = Create2DimArray(rows, columns);
PrintArray(myArray);
if (row <= rows && column <= columns)
    Console.Write($"\n[{row},{column}] -> {myArray[row-1, column-1]}");
else
    Console.Write($"\n[{row},{column}] -> Такого элемента в массиве нет");
    */

//Задача №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Укажите размер массива");
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
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
}
void PrintColumnsAverage(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum[i] = sum[i] + array[j, i];
        }
        sum[i] = Math.Round(sum[i] / (array.GetLength(0)), 2);
    }
    Console.Write("\nСреднее арифметическое каждого стобца: ");
    for (int k = 0; k < sum.Length; k++)
    {
        if (k < sum.Length - 1)
            Console.Write(sum[k] + "; ");
        else
            Console.Write(sum[k]);
    }
}
int[,] myArray = Create2DimArray(rows, columns);
PrintArray(myArray);
PrintColumnsAverage(myArray);
