// //Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     Console.Write("Введите количество строк ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение ");
//     int max = Convert.ToInt32(Console.ReadLine());

//     int[,] myArray = Create2DRandomArray(m, n, min, max);
//     Show2DArray(myArray);



// / void Show2DArray(int[,] array)
// // {
// //     for(int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for(int j = 0; j < array.GetLength(1); j++)
// //         {
// //             Console.Write(array[i,j]+" ");
// //         }
// //         Console.WriteLine();
// //     }
// // }


//     // int[,] myArray = Create2DRandomArray(m,n,min,max);
//     // Show2DArray(myArray);




//     //Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//     // Выведите полученный массив на экран.

// int[,] Create2DRandomArray(int rows, int columns)
//     {
//         int[,] newArray = new int[rows, columns];
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 newArray[i, j] = i + j;
//             }
//         }
//         return newArray;
//     }

//     void Show2DArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     Console.Write("Введите количество строк ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     int[,] myArray = Create2DRandomArray(m, n);
//     Show2DArray(myArray);




//     //Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//     //Например, изначально массив выглядел вот так:

//     //1 4 7 2
//     //5 9 2 3
//     //8 4 2 4
//     //Новый массив будет выглядеть вот так:

//     //1 4 7 2
//     //5 **81  ** 2 **9**
//     //8 4 2 4


//     int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
//     {
//         int[,] newArray = new int[rows, columns];
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//         return newArray;
//     }

//     void Show2DArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {

//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }


//         Console.WriteLine();



//         void Show2DArray1(int[,] array)
//         {
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     if (i % 2 == 0 && j % 2 == 0)
//                         array[i, j] = array[i, j] * array[i, j];
//                     Console.Write(array[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }





//         Console.Write("Введите количество строк ");
//         int m = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите количество столбцов ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите минимальное значение ");
//         int min = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите максимальное значение ");
//         int max = Convert.ToInt32(Console.ReadLine());

//         int[,] myArray = Create2DRandomArray(m, n, min, max);
//         Show2DArray(myArray);
//         Show2DArray1(myArray);


//Задача 4. адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.




// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// void Show2DArray1(int[,] array)
// {
//     int summ=0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             if (i == j )
//                summ=summ+ array[i, j] ;

//         }

//     }
//     Console.WriteLine($" Сума главной диагонали= {summ}");
// }




// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(myArray);
// Show2DArray1(myArray);



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Console.WriteLine(" ******   Задачa 47 **********");

double[,] Create2DRandomArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = Math.Round(new Random().NextDouble(), 1) * (new Random().Next(-10, 10));
        }
    }
    return newArray;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2DRandomArray(m, n);
Show2DArray(myArray);
//Show2DArray1(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine(" ******   массив для Задачи 50 **********");
double[,] MyArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Show2DArray(MyArray);


Console.Write("Введите строкy ");
int I = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбeц ");
int J = Convert.ToInt32(Console.ReadLine());

void NumberIJ(double[,] array, int i, int j)
{
    if (i >= 0 && I < array.GetLength(0))
    {
        if (j >= 0 && j < array.GetLength(1))
        {

            Console.Write(array[i, j] + "  - значение элемента");
        }
        else
        {
            Console.WriteLine("  такого числа в массиве нет  ");
        }
    }
    else
    {
        Console.WriteLine("  такого числа в массиве нет  ");
    }
}



NumberIJ(MyArray, I, J);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" ******   массив для Задачи 52 **********");

double[,] MyArray1 = {
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4}
};

Show2DArray(MyArray1);

void averageROW(double[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumRow = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumRow = sumRow + array[i, j];

        }
        Console.Write(Math.Round(sumRow/(array.GetLength(0)) , 1) + "  ");
    }
    Console.WriteLine();
}

averageROW(MyArray1);