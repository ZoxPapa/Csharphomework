Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (number < 2)
    Console.Write("Number is incorrect");
else 
    while(i <= number)
    {
        Console.Write(i + "/");
        i+=2;
    }