// int numberA = new Random().Next(1,10);
// int numberB = new Random().Next(1,10);
// int result = numberA + numberB;
// Console.WriteLine(result);

// Console.Write("Введите имя пользователя ");
// string username = Console.ReadLine();
//if (username.ToLower() == "Максим")
// {
// Console.WriteLine(" Это же МАКСИМ");
// }
// else
// {
// Console.Write(" Привет ");
// Console.Write(username );
// }

﻿// task5 - (семинар1) - Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
if(x < 0)
{x = x * -1;}
int z = x * -1;
do {Console.Write(z + "/");
    z = z + 1;}
while (z <= x);