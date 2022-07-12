//Задача №27 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int Sum(int value)
{
    int sum = 0;
    while (value / 10 != 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }

    return sum + value;
}
Console.WriteLine($"{a} -> {Sum(a)}");
*/

//Задача №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

int[] myArray = CreateArray(size);
ShowArray(myArray);