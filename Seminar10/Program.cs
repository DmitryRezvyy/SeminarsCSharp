// Задача №1 Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

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