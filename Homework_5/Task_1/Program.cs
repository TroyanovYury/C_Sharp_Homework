// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int length, int start, int end)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(start, end + 1);
    }
    return array;
}
void ShowArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
}


int CountOfEven(int[] Array)
{
    int Count = 0;
    for (int i = 0; i < Array.Length; i++)
        if (Array[i] % 2 == 0)
        {
            Count = Count + 1;
        }
    return Count;
}


int[] Array = new int[4];
Array = GenerateArray(4, 100, 999);
ShowArray(Array);
System.Console.WriteLine();
System.Console.WriteLine("Количество четных чисел массива равно " + CountOfEven(Array));

