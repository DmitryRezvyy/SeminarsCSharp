// Задача №64 Задайте значение N. Напишите программу, которая найдет факториал числа N рекурсивным методом.
/*
Console.WriteLine("Введите число, факториал которого необходимо вычислить:");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
long Factorial(long n)
{
if (n == 0 || n == 1)
return 1;
else
    n = n * Factorial(--n);
return n;
}

Console.WriteLine($"N = {value} -> {Factorial(value)}");
*/

// Задача №66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите начальное значение диапазона натуральных чисел");
int valueM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное значение диапазона натуральных чисел");
int valueN = Convert.ToInt32(Console.ReadLine());
int Sum(int m, int n)
{
    if (n - m > 0)
    {
        m = m + Sum(++m, n);
    }
   return m;
}
Console.WriteLine($"M = {valueM}; N = {valueN} -> {Sum(valueM, valueN)}");
