// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4

int InputInt(string message)
{
    Console.Write($"{message}> ");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("You enter not number");
    Environment.Exit(1);
    return 0;
}

int [,] GenerateArray (int row, int col)
{
     int[,] array = new int[row, col];
     Random rnd = new Random();
     for (int i = 0; i < array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0, 10);
        }
     }
     return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
    }
    Console.WriteLine();
}

int ValidatePosElement(int [,] array, int posRow, int posCol)
{
  if ((posRow > array.GetLength(0)) || (posCol > array.GetLength(1)))
  {
    Console.WriteLine();
    Console.WriteLine("There is no such element in the array!");
    Environment.Exit(1);
    return 0;
  }
  return array[posRow,posCol];
}

Console.WriteLine();
int row = InputInt("Enter number rows in array");
int col = InputInt("Enter number  columns in array");
int [,] array = GenerateArray(row,col);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int posRow = InputInt("Enter position row");
int posCol = InputInt("Enter position col");
Console.WriteLine();
Console.Write($"{posRow}, {posCol} ---> {ValidatePosElement(array, posRow, posCol)}");