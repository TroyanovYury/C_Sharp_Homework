// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message)
{
    System.Console.Write(message); //Вывод приглашения
    int number = Convert.ToInt32(Console.ReadLine()); // Чтение строки и преобразование в число
    return number; // Возврат целого числа
}

bool Validate3sign(int number)
{
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine("Вы ввели не 3-х значное число");
        return false;
    }

    return true;
}

int digit = ReadInt("Ввведите 3-х значное число > ");
if (Validate3sign(digit))
{
    int secondDigit = (digit % 100 - digit % 10) / 10;
    System.Console.WriteLine($"Вторая цифра числа {digit} равна {secondDigit}");
}