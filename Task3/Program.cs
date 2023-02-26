Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 0)
    Console.Write("Inputed number is 0, please input correct number");
else if(number%2 == 0)
    Console.Write($"{number} is even number");
else 
    Console.Write($"{number} is odd number");