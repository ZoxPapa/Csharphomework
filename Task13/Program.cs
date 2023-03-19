// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double GenerateRandomDouble(int min, int max, int round)
{
    double result = (new Random().NextDouble()) * (max - min) + min;
    return Math.Round(result, round);
}

double[,] CreateOutputDouble2DArray(int m, int n, int round)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = GenerateRandomDouble(-10, 11, round);
            Console.Write(Math.Round(array[i, j], 2) + "  ");
        }
        Console.WriteLine(" ");
    }
    return array;
}
// CreateOutputDouble2DArray(4, 4, 1);

//-----------------------------------------------------------------------------------------------
// Напишите программу, которая на вход принимает значение элемента, 
// и возвращает координаты этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

bool FindDigit2DArray( int [,] array, int value)
{
    bool findIt = false;
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == value)
                {
                    Console.WriteLine($"Число {value} имеет координаты ({i}, {j}).");
                    findIt = true;
                }
            }
    }
    if(!findIt)
    {
        Console.WriteLine($"Числа {value} в массиве нет.");
        return false;
    }
    else
        return true;
}

// FindDigit2DArray(Create2DArray(4,4), 3);

//------------------------------------------------------------------------------------------------
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] AverageColumn2DArray(int[,] array)
{
    double[] averages = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            averages[j]+= array[i,j];
        averages[j]/=array.GetLength(0);
    }
    return averages;
}

double[] somearray = AverageColumn2DArray(Create2DArray(4, 10));
Console.Write("Avarege for each column: " + String.Join(" ", somearray));