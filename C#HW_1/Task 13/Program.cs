// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое целое число");
int number = int.Parse(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number <= 999)
{
    int FirstDigit = number / 100;
int flagnumber = number - FirstDigit*100; // Получили десятки и единицы
int SecondDigit = flagnumber / 10;
Console.WriteLine(SecondDigit);
}
