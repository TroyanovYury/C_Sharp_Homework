// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadInput(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

int userNum = ReadInput("Введите число: ");

int sum = 0;

while (userNum > 0)
{
    sum += userNum % 10;
    userNum = userNum / 10;
}


System.Console.WriteLine($"Сумма всех цифр равна {sum}");
