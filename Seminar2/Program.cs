//Задача №10
/*
Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write($"{a} -> {a / 10 % 10}");
*/

//Задача №13
/*
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
void Digit(int x)
{
    int count = 1;
    while (x / 10 >= 1)
    {
        x = x / 10;
        count++;
    } 
if (count <= 2)
Console.Write($"{a} -> Третьей цифры нет");
if (count > 2)
Console.Write($"{a} -> {a / Convert.ToInt32(Math.Pow(10, count-3)) % 10}");
}
Digit(a); 
*/

//Задача №13 - другой вариант решения с преобразованием введенного числа в маасив
/*
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
string[] array = new string[a.ToString().Length];
for (int i = 0; i < a.ToString().Length; i++)
{
array[i] = a.ToString().Substring(i,1);
}
if (a.ToString().Length < 3)
Console.Write($"{a} -> Третьей цифры нет");
else
Console.Write($"{a} -> {array[2]}");
*/


//Задача №15
/*
Console.WriteLine("Введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
string[] array = {"1 -> нет", "2 -> нет", "3 -> нет", "4 -> нет", "5 -> нет", "6 -> да", "7 -> да"};
Console.WriteLine($"{array[a-1]}");
*/

//Задача №15 - другой вариант решения

Console.WriteLine("Введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0 && a < 6)
    Console.WriteLine($"{a} -> нет");
    if (a == 6 || a == 7)
    Console.WriteLine($"{a} -> да");