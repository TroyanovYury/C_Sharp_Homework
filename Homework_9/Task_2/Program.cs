// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int M = ReadInput("Введите натуральное число 1: ");
int N = ReadInput("Введите натуральное число 2: ");

int SumNaturalNums(int M, int N)
{
    if (M == N) return N;
    else
        return M + SumNaturalNums(M + 1, N);
}

System.Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна {SumNaturalNums(M, N)}");