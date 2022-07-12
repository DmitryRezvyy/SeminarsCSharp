//Задача №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());

void IsPalindrom(int value)
{
    string[] array = new string[value.ToString().Length];
    for (int i = 0; i < a.ToString().Length; i++)
    {
        array[i] = value.ToString().Substring(i, 1);
    }
    if (array[0] == array[4] && array[1] == array[3])
        Console.WriteLine($"{value} -> Да");
    else Console.Write($"{value} -> Нет");
}

IsPalindrom(a);
*/

// Задача №21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int aZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
double xLine = x2 - x1;
double yLine = y2 - y1;
double zLine = z2 - z1;
double distQuad = xLine*xLine + yLine*yLine + zLine*zLine;
double result = Math.Sqrt(distQuad);
return result;
}

Console.WriteLine($"A({aX}, {aY}, {aZ}); B({bX}, {bY}, {bZ}) -> {Math.Round(Distance(aX, aY, aZ, bX, bY, bZ), 2)}");
*/

//Задача №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"{a} -> ");
for (int i = 1; i <= a; i++)
{
    if (i > 1)
        Console.Write($", {Math.Pow(i, 3)}");
    else Console.Write($"{1}");
}