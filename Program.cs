// int numberA = new Random().Next(1,10);
// int numberB = new Random().Next(1,10);
// int result = numberA + numberB;
// Console.WriteLine(result);

Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();
if (username.ToLower() == "Максим")
{
Console.WriteLine(" Это же МАКСИМ");
}
else
{
Console.Write(" Привет ");
Console.Write(username );
}
