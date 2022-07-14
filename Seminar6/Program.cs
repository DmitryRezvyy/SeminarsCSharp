//Задача №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Введите целые числа через запятую");
string a = Console.ReadLine();
int PositiveItemCount(string input)
{
    string[] data = input.Split(",").ToArray();
    int sum = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if (Convert.ToInt32(data[i]) > 0)
            sum++;
    }
    return sum;
}
Console.WriteLine(a + $" -> {PositiveItemCount(a)}");
*/

//Задача №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y= k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение k1");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1");
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;
if (k1 != k2 && b1 != b2)
{
    x = Math.Round((b2 - b1) / (k1 - k2), 2);
    y = Math.Round((k1*b2 - k2 * b1) / (k1 - k2), 2);
    Console.WriteLine($"Координаты точки пересечения прямых ({x};{y})");
}
else if (k1 == k2 && b1 != b2)
{
     Console.WriteLine("Прямые параллельны");
}
else Console.WriteLine("Прямые совпадают");

