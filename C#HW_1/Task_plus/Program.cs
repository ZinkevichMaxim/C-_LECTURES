Console.WriteLine("Введите любое целое число");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if (number > 999)
{
    while (number > 999)
    {
        number = number / 10;
        }
}

if (number <= 999)
{
int FirstDigit = number / 100;
int flagnumber = number - FirstDigit*100; // Получили десятки и единицы
int SecondDigit = flagnumber / 10;
Console.WriteLine(SecondDigit);
}





