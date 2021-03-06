//Задача №34 - Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int EvenItemCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        Console.Write(array[i] +", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(a);
ShowArray(myArray);
Console.WriteLine($" -> {EvenItemCount(myArray)}");
*/

//Задача №36 Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
            Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int SumEvenPositionItem(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(a);
ShowArray(myArray);
Console.WriteLine($" -> {SumEvenPositionItem(myArray)}");
*/

//Задача №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (new Random().Next(101)), 2);
    }
    return array;
}

void ShowArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
            Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

double MaxMinItemDelta(double[] array)
{
    double diff = 0;
    diff = array.Max() - array.Min();
    return diff;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(a);
ShowArray(myArray);
Console.WriteLine($" -> {MaxMinItemDelta(myArray)}");