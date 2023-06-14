// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец

Console.Clear();


int Prompt(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i,j]}; ");
        Console.WriteLine();
    }
    
}


int rows = Prompt("Введите колличество строк в массиве ");
int columns = Prompt("Введите колличество столбцов в массиве ");
int minValue = Prompt("Введите минимальное значение в массиве ");
int maxValue = Prompt("Введите максимальное значение в массиве ");

int [,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);

int Elemrow = Prompt("Введите строку, на котором находится искомый элемент ");
int Elemcolumn = Prompt("Введите столбец, в котром находится искомый элесент");
FindElem(array);


void FindElem(int[,] array)
{
if(Elemrow < rows && Elemcolumn < columns)
{
    Console.WriteLine($"Значение искомого элемента равно {array[Elemrow, Elemcolumn]}");
}
else
{
    Console.WriteLine($"Такого элемента в массивен нет ");
}
}

