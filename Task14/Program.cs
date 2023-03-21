// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void Output2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
int[,] Sort2DArray(int[,] array)
{
    int[] array1d = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array1d[j] = array[i, j];
        Array.Sort(array1d);
        Array.Reverse(array1d);
        for (int j = 0; j < array1d.Length; j++)
            array[i, j] = array1d[j];
    }
    Console.WriteLine();
    return array;
}
// Output2DArray(Sort2DArray(Create2DArray(3, 10)));

//-----------------------------------------------------------------------------------------------

// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FindMinRow(int[,] array)
{
    int[] array1d = new int[array.GetLength(0)];
    int minRowNumber = 0;
    for (int i = 0, minSumRow = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array1d[i] += array[i, j];
        if (i == 0) minSumRow = array1d[0];
        if (array1d[i] < minSumRow)
        {
            minSumRow = array1d[i];
            minRowNumber = i;
        }
    }
    Console.WriteLine($"Row with minimal sum of numbers is {minRowNumber + 1}");
}
// FindMinRow(Create2DArray(6,3));

//-----------------------------------------------------------------------------------------------

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Multiple2dArray(int[,] firstArray, int[,] secondArray)
{
    if (firstArray.GetLength(1) != secondArray.GetLength(0))
    {
        Console.WriteLine("This matrices can't be multiplied. Change qty columns and rows. ");
        int[,] badresult = new int[1, 50];
        return badresult;
    }
    else
    {
        int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int k = 0; k < secondArray.GetLength(1); k++)
            {
                for (int j = 0; j < secondArray.GetLength(0); j++)
                    result[i, k] += firstArray[i, j] * secondArray[j, k];
            }
        }
        return result;
    }
}
// int [,] firstArray = Create2DArray(4,4);
// Console.WriteLine();
// int [,] secondArray = Create2DArray(4,3);
// int [,] firstArray = Create2DArray(3,2);
// Console.WriteLine();
// int [,] secondArray = Create2DArray(2,4);
// Console.WriteLine();
// Output2DArray(Multiple2dArray(firstArray, secondArray));

//------------------------------------------------------------------------------------------------

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateOutput3DArray(int m, int n, int z)
{
    if (m * n * z > 90)
    {
        Console.WriteLine("Error.Imposible to create 2digits array with this parametres.");
        int[,,] badresult = new int[1, 1, 50];
        return badresult;
    }
    int[,,] array = new int[m, n, z];
    int difference = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = 9 + difference;
                Console.Write(array[i, j, k] + $"({i},{j},{k}) ");
                difference += 1;
            }
            Console.WriteLine();
        }
    }
    return array;
}
// CreateOutput3DArray(3,3,10);

//-------------------------------------------------------------------------------------------------

// Напишите программу, которая заполнит спирально массив n x m.

int[,] FillSpiral(int[,] array)
{
    int i = 0, j = 0, count = 1;
    array[i, j] = count;
    while (count < array.GetLength(0) * array.GetLength(1))
    {
        while (j + 1 < array.GetLength(1) && array[i, j + 1] == 0) //Filling right
        {
            j++;
            count++;
            array[i, j] = count;
        }
        while (i + 1 < array.GetLength(0) && array[i + 1, j] == 0) //Filling down
        {
            i++;
            count++;
            array[i, j] = count;
        }
        while (j - 1 >= 0 && array[i, j - 1] == 0) // Filling left
        {
            j -= 1;
            count++;
            array[i, j] = count;
        }
        while (array[i-1, j] == 0) // filling up
        {
            i -= 1;
            count++;
            array[i, j] = count;
        }
    }
    return array;

}
// int[,] array = new int[7, 7];
// Output2DArray(FillSpiral(array));
