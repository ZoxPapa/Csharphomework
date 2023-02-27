Console.Write("Please input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >99 || num <-99)
    Console.Write($"Third digit is {(num/100)%10}");
else 
    Console.Write("Third digit is absent");