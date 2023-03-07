int Prompt()
{
    Console.Write("Input number: ");
    return Convert.ToInt32(Console.ReadLine());
}

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("First number - it's number witch we'll raise to the power: ");
// int firstNum = Prompt();
// Console.WriteLine("Second number - it's the power: ");
// int secondNum = Prompt();
// Console.WriteLine(Math.Pow(firstNum, secondNum));

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

