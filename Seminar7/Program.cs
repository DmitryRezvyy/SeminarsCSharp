//Задача №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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