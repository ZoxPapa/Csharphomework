Console.Write("Input first number: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int second_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int third_num = Convert.ToInt32(Console.ReadLine());
int max = first_num;
if (first_num < second_num)
    max = second_num;
if (third_num > max)
    max = third_num;

Console.Write($"Max number is: {max}");
