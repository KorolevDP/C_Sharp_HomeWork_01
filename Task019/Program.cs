// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

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

double [,] GenerateArray (int row, int col)
{
     double[,] array = new double[row, col];
     Random rnd = new Random();
     for (int i = 0; i < array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(10) + Math.Round(rnd.NextDouble(), 1);
        }
     }
     return array;
}

void PrintArray (double[,] array)
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

int row = InputInt("Enter number rows in array");
int col = InputInt("Enter number  columns in array");
double [,] array = GenerateArray(row,col);
Console.WriteLine();
Console.Write($" m = {row}, n = {col}.");
Console.WriteLine();
PrintArray(array);