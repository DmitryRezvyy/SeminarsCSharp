// Задача 2

/*
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int Max(int x, int y)
{
int max = x;
if (y > x)   max = y;
return max;
}
Console.WriteLine($"a = {a}; b = {b} -> max = {Max(a, b)}");   */ 


// Задача 4

/*
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());


int Max(int x, int y, int z)
{
int max = x;
if (y > x) max = y;
if (z > y) max = z;   
return max;
}
Console.WriteLine($"{a} {b} {c} -> {Max(a, b, c)}");   */


// Задача 6
/*
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
Console.WriteLine($"{a} -> да");
else
Console.WriteLine($"{a} -> нет");  */


// Задача 8

Console.WriteLine("Введите целое положительное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"{a} -> ");
int digit = 1;
while (digit <= a)
{
if (digit % 2 == 0)
{
    if (digit == 2) Console.Write($"{digit}");
    else Console.Write($", {digit}");
}
digit++;
}