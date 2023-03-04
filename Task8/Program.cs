Console.Write("Input legth of number: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input {len} digits number: ");
string digits = Console.ReadLine();
int number = Convert.ToInt32(digits); //Проверка, что введено число
bool result = true;

if(digits.Length != len) // Проверка, что число нужной длины
    Console.WriteLine($"Error. You need to input {len} digits number. ");
else
{
    for (int i = 0 ; i < (len-1-i); i++)
    {
        if(digits[i] == digits[(len-1-i)]) //Проверка на полиндромность
            result = true;
        else result = false;
            break;
    }
    if(result == true)
        Console.Write("It's polyndrome ");
    else Console.Write("It's not polyndrome ");
}
