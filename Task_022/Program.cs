// Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

int[,] GenerateMatrix(int row, int col)
{
    int[,] matrix = new int[row,col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]}\t");
    }
  }  
  Console.WriteLine();
}

void SortElemRow(int[] array)
{
    Array.Sort(array);
    Array.Reverse(array);
}

void InsertRow(int dim, int[] array, int[,] matrix)
{
    for (int i = 0; i < array.Length; i++)
    {
        matrix[dim, i] = array[i];
    }
}

void SortRowsMatrix(int[,] matrix)
{
    int[] row = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            row[k] = matrix[j, k];
        }
        SortElemRow(row);
        InsertRow(j, row, matrix);
    }
}

int row = InputInt("Enter number rows in array");
int col = InputInt("Enter number  columns in array");
int [,] userMatrix = GenerateMatrix(row,col);
Console.WriteLine();
PrintMatrix(userMatrix);
Console.WriteLine();
SortRowsMatrix(userMatrix);
PrintMatrix(userMatrix);