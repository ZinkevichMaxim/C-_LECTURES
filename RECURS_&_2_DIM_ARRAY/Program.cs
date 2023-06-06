1. Структура двумерного массива
2. МЕТОДЫ ЗАПОЛНЕНИЯ И ПЕЧАТИ ДВУУРОВНЕВЫХ МАССИВОВ
3. РЕКУРСИЯ - СИТУАЦИЯ, КОГДА МЕТОД ВЫЗЫВАЕТ САМ СЕБЯ
4. Решение задачи Факториала - произведение чисел от единицы до заданного
5. ЧИСЛА ФЕБОНАЧИ




// Тип данных кол-во срок  и столбцов  имя
// string     [           ,          ] table = new string[2, 3]
// int        [            ,         ] matrix = new int[5, 8]

// Индксы меняются от 0

// String.Empty - инициализация СТРОК

// table[0,0];    table[0,1];   table[0,2];   table[0,3];     table[0,4];
// table[1,0];    table[1,1];   table[1,2];   table[1,3];     table[1,4];


// string[,] table = new string[2, 5]; // nтаблица, фактически

// table[1, 2] = "слово";   // вызвали элемент и присвоили значение


// for(int rows = 0; rows < 2; rows++)
// {
//     for(int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"{table[rows, colums]}"); // в консоль выведется соответствующий элемент
//         // Console.WriteLine($"-{table[rows, colums]}-"); если обрамить минусами (-) то выведутся все элементы
//     }
// }

// int[,] matrix = new int[5, 8];

МЕТОДЫ ЗАПОЛНЕНИЯ И ПЕЧАТИ ДВУУРОВНЕВЫХ МАССИВОВ

// void PrintArray(int[,] matrix)
// {
// for(int rows = 0; rows < matrix.GetLength(0); rows++)    // matrix.GetLength(0) - количество строк, пишем (0)
// {
//     for(int colums = 0; colums < matrix.GetLength(1); colums++)   // matrix.GetLength(1) - количество столбцов, пишем (1) Как вариант конструкции 0 и 1 аналог длина строки и длина столбца 
//     {
//         Console.WriteLine($"-{table[rows, colums]}-"); // в консоль выведется соответствующий элемент
        
//     }
// }
// }

// void FillArray(int[,] matrix)
// {
// for(int rows = 0; rows < matrix.GetLength(0); rows++)    // matrix.GetLength(0) - количество строк, пишем (0)
// {
//     for(int colums = 0; colums < matrix.GetLength(1); colums++)   // matrix.GetLength(1) - количество столбцов, пишем (1) Как вариант конструкции 0 и 1 аналог длина строки и длина столбца 
//     {
//         matrix[i,j] = new Random().Next(1, 10);        
//     }
// }
// }

РЕКУРСИЯ - СИТУАЦИЯ, КОГДА МЕТОД ВЫЗЫВАЕТ САМ СЕБЯ

Решение задачи Факториала - произведение чисел от единицы до заданного 
// 5! = 5 * 4 * 3 * 2 * 1
//     5*4!
//          4*3!
//              3*2!
//                  2*1!

// int Factorial(int num)
// {
//     //  1! = 1
//     //  0! = 1 
//     if (num == 1)
//     {
//         return 1;
//     }
//     else
//     {
//         return n * Factorial(n-1);
//     }
// }

ЧИСЛА ФЕБОНАЧИ

// F.n = F.n-1 + F.n-2


