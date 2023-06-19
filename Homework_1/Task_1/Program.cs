// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите первое число: ");
string number_1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string number_2 = Console.ReadLine();
int num_1 = Convert.ToInt32(number_1);
int num_2 = Convert.ToInt32(number_2);
if (num_1 == num_2)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (num_1 > num_2)
{
    Console.WriteLine("Первое число больше второго");
}
    else
    {
    Console.WriteLine("Второе число больше первого");
    }
}