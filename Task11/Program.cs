int Prompt()
{
    Console.Write("Input number: ");
    return Convert.ToInt32(Console.ReadLine());
}
int[] ArrayFillInt(int qty)
{
    int[] numbers = new int[qty];
    for (int i = 0; i < qty; i++)
        numbers[i] = new Random().Next(1, 11);
    return numbers;
}
void ArrayPrint(int[] somearray)
{
    Console.Write("[");
    for (int i = 0; i < somearray.Length - 1; i++)
        Console.Write(somearray[i] + ", ");
    Console.Write(somearray[somearray.Length - 1] + "]");
    Console.WriteLine();
}
int MathPow(int po, int ex)
{
    int result = po;
    for (int i = 1; i < ex; i++)
        result *= po;
    return result;
}

//----------------------------------------------------------------------------------------------
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("First number - it's number witch we'll raise to the power: ");
// int firstNum = Prompt();
// Console.WriteLine("Second number - it's the exponent: ");
// int secondNum = Prompt();
// Console.WriteLine(MathPow(firstNum, secondNum));

//---------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int DigitsSum(int n)
// {
//     int sum = 0;
//     for (int current = n; current > 0; current /= 10)
//         sum += current % 10;
//     return sum;
// }
// Console.WriteLine(DigitsSum(Prompt()));
//---------------------------------------------------------------------------------------------

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Console.WriteLine("Input size of array: ");
// int[] firstArray = ArrayFillInt(Prompt());
// ArrayPrint(firstArray);

//-----------------------------------<Homework 9.3.2023>--------------------------------------------

// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] ArrayFill3digits(int qty)
{
    int[] numbers = new int[qty];
    for (int i = 0; i < qty; i++)
        numbers[i] = new Random().Next(100, 1000);
    return numbers;
}
int FindPositive(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            counter +=1;
    }
    return counter;
}

// int[] threedigitsarray = ArrayFill3digits(8);
// ArrayPrint(threedigitsarray);
// Console.WriteLine($"Quantity of even numbers is {FindPositive(threedigitsarray)}");
//---------------------------------------------------------------------------------------------

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int SumOddInArray (int[]array)
{
    int result = 0;
    for (int i = 1; i <array.Length; i+=2)
        result +=array[i];
    return result;
}
// int[] array4SumOdd = ArrayFillInt(8);
// Console.WriteLine(String.Join(" ", array4SumOdd));
// Console.WriteLine(SumOddInArray(array4SumOdd));
//---------------------------------------------------------------------------------------------

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double[] ArrayFillDouble(int qty)
{
    double[] numbers = new double[qty];
    for (int i = 0; i < qty; i++)
        numbers[i] = new Random().Next(1, 11);
    return numbers;
}
double DiffMaxMinArray(double [] array)
{
    double min = array[0];
    double max = array[0];
    for(int i =0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    return max - min;  
}

// double[] arrayOfDouble = ArrayFillDouble(5);
// Console.WriteLine(String.Join(" ", arrayOfDouble));
// Console.WriteLine(DiffMaxMinArray(arrayOfDouble));

//---------------------------------------------------------------------------------------------