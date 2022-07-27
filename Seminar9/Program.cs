// Задача №64 Задайте значение N. Напишите программу, которая найдет факториал числа N рекурсивным методом.

Console.WriteLine("Введите число, факториал которого необходимо вычислить:");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int Factorial(int n)
{
if (n == 0 || n == 1)
return 1;
else
    n = n * Factorial(--n);
return n;
}

Console.WriteLine($"N = {value} -> {Factorial(value)}");


