// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int M = ReadInput("Введите натуральное число 1: ");
int N = ReadInput("Введите натуральное число 2: ");

int AkkermanF(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return AkkermanF(M - 1, 1);
    }
    else
    {
        return (AkkermanF(M - 1, AkkermanF(M, N - 1)));
    }
}
System.Console.Write($"Функция Аккермана для чисел {M} и {N} равна: {AkkermanF(M, N)}");
