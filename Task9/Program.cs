void Coordinates (int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"Input {i+1} coordinate: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int [] dota = new int[3];
int [] dotb = new int[3];
Coordinates(dota);
Coordinates(dotb);
double result = 0;
for(int i =0; i < 3; i++)
{
    result = result + Math.Pow((dota[i]-dotb[i]),2);
}
Console.WriteLine($"Distance between A & B is: {Math.Round(Math.Sqrt(result), 2)}");