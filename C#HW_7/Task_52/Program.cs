// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            result[i,j] = new Random().Next(minValue, maxValue +1);
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



double[] GetArray2(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        result[j] = Math.Round(sum / array.GetLength(0), 2);
    }
    return result;
}

void PrintArray2(double[] array2)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array2[i]);
    }
}

double[] array2 = GetArray2(array);
PrintArray2(array2);