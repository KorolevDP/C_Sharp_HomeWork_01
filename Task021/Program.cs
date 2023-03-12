// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int [,] GenerateMatrix (int row, int col)
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

void PrintMatrix (int[,] array)
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

double[] AverageColumn(int[,] array)
{
  double[] averagesArray = new double[array.GetLength(1)];
  for (int j = 0; j < array.GetLength(1); j++)
  {
     int sumCol = 0;
     for (int i = 0; i < array.GetLength(0); i++)
     {
        sumCol += array[i,j];
     }
     averagesArray[j] = sumCol / array.GetLength(0);
  }
  return averagesArray;
}

void PrintArray (double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item:F2}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
int row = InputInt("Enter number rows in array");
int col = InputInt("Enter number  columns in array");
int [,] array = GenerateMatrix(row,col);
Console.WriteLine();
PrintMatrix(array);
Console.WriteLine();
double[] averageArray = AverageColumn(array);
PrintArray(averageArray);