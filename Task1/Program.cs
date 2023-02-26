Console.Write("Input first number: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int second_num = Convert.ToInt32(Console.ReadLine());
if (first_num > second_num)
    Console.Write("{0} is bigger than {1}.", first_num, second_num);
else if (first_num < second_num)
    Console.Write("{1} is bigger than {0}.", first_num, second_num);
else Console.Write("Numbers are equal.");