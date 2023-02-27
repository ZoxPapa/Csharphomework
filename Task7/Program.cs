Console.Write("Please input number of the day of the week (1 to 7): ");
int day = Convert.ToInt32(Console.ReadLine());
if(day >0 && day < 6)
    Console.Write("Опять работа?");
else if(day >5 && day <8)
    Console.Write("Выходной. Нужно построить зиккурат");
else
    Console.Write("Error. There are only 7 days in a week =)");