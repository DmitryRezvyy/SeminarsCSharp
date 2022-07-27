// Задача №1 Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/*
Console.WriteLine("Введите размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} слово");
        array[i] = Console.ReadLine();
    }
    return array;
}
string[] myVowelLetterArray = { "а", "е", "ё", "и", "о", "у", "ы", "э", "ю", "я", "a", "e", "i", "o", "u", "y" };
string[] myArray = CreateArray(arraySize);
int counter = 0;
foreach (string item in myArray)
{
    for (int i = 0; i < myVowelLetterArray.Length; i++)
    {
        if (item[0].ToString().ToLower() == myVowelLetterArray[i])
            counter++;
    }
}
Console.Write("{");
for (int i = 0; i < myArray.Length; i++)
{
    if (i == myArray.Length - 1)
        Console.Write("\"" + myArray[i] + "\"}");
    else
        Console.Write("\"" + myArray[i] + "\", ");
}
Console.Write($" -> {counter}");
*/

// Задача №2 Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

Console.WriteLine("Введите размер массива кратный 2");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} слово");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write("\"" + array[i] + "\"}");
        else
            Console.Write("\"" + array[i] + "\", ");
    }
}
string[] myArrayA = CreateArray(arraySize);
string[] myArrayB = new string[arraySize / 2];
for (int i = 0; i < myArrayB.Length; i++)
{
    for (int j = i * 2; j < i * 2 + 2; j++)
    {
        myArrayB[i] = myArrayB[i] + myArrayA[j];
    }
}

PrintArray(myArrayA);
Console.Write($" -> ");
PrintArray(myArrayB);