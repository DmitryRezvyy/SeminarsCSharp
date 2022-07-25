//Задача №54 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
/*
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
*/

//Задача №58 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Console.WriteLine("Укажите число строк матрицы А: ");
int rowsA = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Укажите число столбцов матрицы А (строк матрицы B): ");
int columnsA = Convert.ToInt16(Console.ReadLine());
int rowsB = columnsA;
Console.WriteLine("Укажите число столбцов матрицы B: ");
int columnsB = Convert.ToInt16(Console.ReadLine());
int[,] Create2DimArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = new Random().Next(1, 10);
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
int[,] MatrixMultiplication(int[,] m, int[,] n)
{
    int[,] newArray = new int[m.GetLength(0), n.GetLength(1)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < m.GetLength(1); k++)
            {
                newArray[i, j] = newArray[i, j] + m[i, k] * n [k, j];
            }
            
        }
    }
    return newArray;
}
int[,] myArrayA = Create2DimArray(rowsA, columnsA);
int[,] myArrayB = Create2DimArray(rowsB, columnsB);
int[,] myArrayC = new int[rowsA, columnsB];
myArrayC = MatrixMultiplication(myArrayA, myArrayB);
Console.WriteLine("\nМатрица А:");
PrintArray(myArrayA);
Console.WriteLine("\nМатрица B:");
PrintArray(myArrayB);
Console.WriteLine("\nПроизведение матриц:");
PrintArray(myArrayC);
*/

//Задача №60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. массив размером 2 x 2 x 2

Console.WriteLine("Укажите размер массива (не менее 2 и не более 4): ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Укажите минимальное значение диапазона (не менее 10 и не более {99 - Math.Pow(size, 3)}): ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Укажите максимальное значение диапазона (не менее {min + Math.Pow(size, 3) - 1} и не более 99): ");
int max = Convert.ToInt32(Console.ReadLine());
int[,,] Create3DimArray(int size1, int size2, int size3, int[] value)
{
    int[,,] newArray = new int[size1, size2, size3];
    int f = 0;
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                newArray[i, j, k] = value[f];
                f++;
            }
        }
    }
    return newArray;
}
int[] Unique2DigitIntValue(int min, int max)
{
    int[] array = new int[max - min + 1];
    int value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        value = new Random().Next(min, max + 1);
        if (array.Contains(value))
            i--;
        else
            array[i] = value;
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,,] myArray = Create3DimArray(size, size, size, Unique2DigitIntValue(min, max));

PrintArray(myArray);
