Console.Clear();

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



// double[] GetArray(int len, int minValue, int maxValue)
// {
//     double [] arr = new double[len];
//     for(int i = 0; i < len; i++)
//     {
//         arr[i] = Convert.ToDouble(new Random().Next(minValue, maxValue)) / 100;
//     }
//     return arr;
// }

// void PrintArray2(double[] aarr)
// {
//     for(int i = 0; i < aarr.Length; i++)
//     {
//         Console.Write($"{aarr[i]}, ");
//     }
// }


// void PrintArray(double[] aarr)
// {
//     for(int i = 0; i < aarr.Length; i++)
//     {
//         Console.Write($"{aarr[i]}, ");
//     }
// }


// void FindMinMax(double[] arrr)
// {
//     double min = arrr[0];
//     double max = arrr[0];
//     for(int i = 0; i < arrr.Length; i++)
//     {
//         if(min > arrr[i])
//         {
//             min = arrr[i];
//         }
//         if (max < arrr[i])
//         {
//             max = arrr[i];
//         }
//     }
//         Console.Write($"Минимальный элемент в цикле = {min}. Максимальный элемент в цикле = {max}. Разниуа между максимальным и минимальным элементами сотавляет {max - min}");
    
// }

// double[] array = GetArray(10, -1258, 8);
// PrintArray2(array);
// Console.WriteLine();
// FindMinMax(array);
// Console.WriteLine();

int rows = Prompt("Введите колличество строк массива");
int columns = Prompt("Введите колличество столбцов массива");
int minValue = Prompt("Введите минимальное значение в масиве");
int maxValue = Prompt("Введите максимальное значение в масиве");

double[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);


int Prompt(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double [m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result [i,j] = Convert.ToDouble(new Random().Next(minValue, maxValue)) / 100;
        }
    }
    return result;
}

void PrintArray(double[,] arr)
{
    for( int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}; ");
        }
        Console.WriteLine();
    }
}