// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите число для проверки: ");
string number = Console.ReadLine();
string reverse = string.Empty;

for (int i = number.Length - 1; i >= 0; i--)
{
    reverse += number[i];
}

if (number == reverse)
{
    Console.WriteLine($"{number} является палиндромом.");
}
else
{
    Console.WriteLine($"{number} не палиндром.");
}
Console.ReadKey();