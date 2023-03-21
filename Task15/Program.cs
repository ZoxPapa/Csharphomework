//------------------------------------------------------------------------------------------------

//Вывести первые N строк треугольника Паскаля. 
//Сделать вывод в виде равнобедренного треугольника

void PascalTriangle(int qtyrows)
{
    int horizontalposition = 50;
    int verticalposition = 1;
    int[] firstRow = { 0, 1, 0 };
    Console.SetCursorPosition(horizontalposition, verticalposition);
    Console.WriteLine(String.Join("", firstRow));
    for (int j = 0; j < qtyrows - 1; j++)
    {
        Console.SetCursorPosition(horizontalposition - 1 - j, verticalposition + 1 + j);
        int[] secondRow = new int[firstRow.Length + 2];
        secondRow[1] = 1;
        secondRow[secondRow.Length - 2] = 1;
        for (int i = 1; i < firstRow.Length - 2; i++)
            secondRow[i + 2] = firstRow[i] + firstRow[i + 2];
        Console.WriteLine(String.Join("", secondRow));
        firstRow = secondRow;
    }
}
PascalTriangle(8);