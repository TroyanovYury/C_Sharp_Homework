// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateArr(int rows, int cols)
{
    int[,] arrayD2 = new int[rows, cols];

    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = new Random().Next(0, 10);
        }
    }
    return arrayD2;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");

        }
        System.Console.WriteLine();
    }
}
int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int rows = ReadInt("Введите число строк");
int columns = ReadInt("Введите число столбцов");
int[,] array = CreateArr(rows, columns);
ShowArray(array);
Console.WriteLine();

int positionRow = ReadInt("Введите номер строки элемента") - 1;
int positionColumn = ReadInt("Введите номер столбца элемента") - 1;

if (positionRow >= 0 && positionRow < rows && positionColumn >= 0 && positionColumn < columns)
{
    Console.WriteLine($"Значение элемента: {array[positionRow, positionColumn]}");
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}
