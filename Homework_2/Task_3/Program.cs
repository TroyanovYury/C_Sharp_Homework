// Задача 3: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message)
{
    Console.Write(message); // Вывод приглашения
    int number = System.Convert.ToInt32(Console.ReadLine()); // Чтение строки и преобразование в число
    return number; // Возврат целого числа
}


int day = ReadInt("Введите номер дня недели -> ");

if (day > 7 || day < 1)
{
    System.Console.WriteLine("Это не день недели!");
}
else if (day == 6 || day == 7)
{
    System.Console.WriteLine("Выходной, однако!");
}
else if (day <= 5)
{
    System.Console.WriteLine("Опять работать... >_< ");
}