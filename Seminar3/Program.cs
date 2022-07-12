Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());

void IsPalindrom(int value)
{
    string[] array = new string[value.ToString().Length];
    for (int i = 0; i < a.ToString().Length; i++)
    {
        array[i] = value.ToString().Substring(i, 1);
    }
    if (array[0] == array[4])
    {
        if (array[1] == array[3])
            Console.WriteLine($"{value} -> Да");
    }
    else Console.Write($"{value} -> Нет");
}

IsPalindrom(a);