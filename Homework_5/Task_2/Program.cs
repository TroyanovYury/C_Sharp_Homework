// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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


int SumNotEven(int[] Array)
{
    int sum = 0;
    for (int i = 1; i < Array.Length; i += 2)
    {
        sum += Array[i];
    }
    return sum;
}

int[] arr = GenerateArray(4, -99, 99);
ShowArray(arr);
System.Console.WriteLine();
System.Console.WriteLine(SumNotEven(arr));

