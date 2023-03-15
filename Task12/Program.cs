//------------------------------------<Homework 9.3.2023>----------------------------------------
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int [] StrNumToArray(string numbers)
{
string [] array = numbers.Split(",");
int [] nums = new int[array.Length];
// Console.WriteLine(String.Join(" ", array));
for(int i=0; i < array.Length; i++)
    nums[i] = Convert.ToInt32(array[i]);
return nums;
}

int FindPositive(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            counter ++;
    }
    return counter;
}

// Console.WriteLine("Input some positive and negative numbers separated by commas: ");
// int [] array = StrNumToArray(Console.ReadLine());
// Console.WriteLine(FindPositive(array));

//------------------------------------------------------------------------------------------------

//Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] StrNumToDoubleArray(string numbers)
{
string [] array = numbers.Split(",");
double [] nums = new double[array.Length];
for(int i=0; i < array.Length; i++)
    nums[i] = Convert.ToDouble(array[i]);
return nums;
}
string Cross (double []firstLine, double []secondLine)
{
    double x = (firstLine[0]-secondLine[0])/(secondLine[1]-firstLine[1]);
return $"Coordinates: ({x}, {firstLine[1]*x+firstLine[0]})";
}

Console.WriteLine("Input b1, k1 for the first line: ");
double [] firstLine = StrNumToDoubleArray(Console.ReadLine());
Console.WriteLine("Input b2, k2 for the second line: ");
double [] secondLine = StrNumToDoubleArray(Console.ReadLine());


Console.WriteLine(Cross(firstLine, secondLine));