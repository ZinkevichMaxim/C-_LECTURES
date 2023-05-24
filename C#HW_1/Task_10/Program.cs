// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int number = int.Parse(Console.ReadLine());
// int FirstDigit = number / 100;
// int flagnumber = number - FirstDigit*100; // Получили десятки и единицы
// int SecondDigit = flagnumber / 10;
// Console.WriteLine(SecondDigit);

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
if (number > 999)
{
    Console.WriteLine("Введите трехзначное число");
    }
else if (number < 100)
{
    Console.WriteLine("Введите трехзначное число");
    }
else
{
    int FirstDigit = number / 100;
int flagnumber = number - FirstDigit*100; // Получили десятки и единицы
int SecondDigit = flagnumber / 10;
Console.WriteLine(SecondDigit);
}

