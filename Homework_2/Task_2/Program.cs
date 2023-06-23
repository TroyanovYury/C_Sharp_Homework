// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string message)
{
    Console.Write(message); // Вывод приглашения
    int number = System.Convert.ToInt32(Console.ReadLine()); // Чтение строки и преобразование в число
    return number; // Возврат целого числа
}
int ThirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры в заданном числе нет");
        return false;
    }
    return true;
}

int number = ReadInt("Введите число > ");
if (ValidateNumber(number))
{
    System.Console.WriteLine($"Третья цифра заданного числа {number} равна {ThirdDigit(number)}");
}
