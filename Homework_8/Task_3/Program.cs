// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

int[,] matrix1 = { { 5, 6 }, { 8, 4 } };
int[,] matrix2 = { { 7, 6, 2 }, { 5, 5, 3 } };

System.Console.WriteLine("Исходная матрица 1");

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        System.Console.Write(matrix1[i, j] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Исходная матрица 2");

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        System.Console.Write(matrix2[i, j] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
int[,] result = MultiplyMatrices(matrix1, matrix2);

System.Console.WriteLine("Результат произведения матриц:");

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        System.Console.Write(result[i, j] + " ");
    }
    System.Console.WriteLine();
}


static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}


