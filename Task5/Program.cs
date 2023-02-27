Console.Write("Please input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 && num <1000)
    Console.Write($"Result is - {(num/10)%10}");
else
    Console.Write("Error. You input wrong number.");