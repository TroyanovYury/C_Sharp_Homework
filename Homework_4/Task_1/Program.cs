// Задача 1: Напишите цикл, который принимает на 
// вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadInput(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
int a = ReadInput("Введите первое число: ");
int b = ReadInput("Введите второе число: ");

int step = a;

for (int i = 1; i < b; i++)
{
    step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);