// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetweenNumbers(int a, int b)
{
    int result = 0;
    if (a > b)
    {
        int temp = b;
        b = a;
        a = temp;
    }
    if (a < b)
        return result = a + SumBetweenNumbers(a + 1, b);
    return result + b;
}
// Console.WriteLine("Input 2 numbers to find sum of numbers between them");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumBetweenNumbers(n, m));

//----------------------------------------------------------------------------------------------

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}
Console.WriteLine(AckermannFunction(3, 8));