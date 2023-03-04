Console.Write("Please input number: ");

//Для вывода третьей цифры справа:
// int num = Convert.ToInt32(Console.ReadLine());
// if(num >99 || num <-99)
//     Console.Write($"Third digit is {(num/100)%10}");
// else 
//     Console.Write("Third digit is absent");

//Для вывода третьей цифры слева:
string num = Console.ReadLine();
if(num.Length>2)
    Console.Write($"Third number is: {num[2]}");
else
    Console.Write("Third digit is absent");
    