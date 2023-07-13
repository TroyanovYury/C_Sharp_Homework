// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArr()
{
    Random rnd = new Random();
    int rows = 4;
    int cols = 4;
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void ShowArrayD2(int[,] array)
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

int FindMinSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int minSumRow = 0;
    int minSum = CalculateRowSum(array, 0);

    for (int i = 1; i < rows; i++)
    {
        int sum = CalculateRowSum(array, i);

        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
    }
    return minSumRow;
}
int CalculateRowSum(int[,] array, int row)
{
    int sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[row, j];
    }

    return sum;
}


int[,] array = CreateArr();
System.Console.WriteLine("Исходный массив:");
ShowArrayD2(array);

int minSumRow = FindMinSum(array);
int minSum = CalculateRowSum(array, minSumRow);
System.Console.WriteLine($"Строка под номером {minSumRow + 1} имеет наименьшую сумму элементов: {minSum}");
