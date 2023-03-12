 //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int RowMinSumElements (int[,] matrix)
{
    int minSumLine = 0;
    int sumLine = SumLineElements(matrix,0);
    for(int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(matrix,i);
            if( sumLine > tempSumLine )
            {
               sumLine = tempSumLine;
               minSumLine = i;
            }
    }
    return minSumLine;
}

int SumLineElements(int[,] matrix, int i)
{
    int sumLine = matrix[i,0];
    for(int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i,j];
    }
    return sumLine;
}

int row = InputInt("Enter number rows in array");
int col = InputInt("Enter number  columns in array");
int [,] userMatrix = GenerateMatrix(row,col);
Console.WriteLine();
PrintMatrix(userMatrix);
Console.WriteLine();
Console.WriteLine($"The row with the smallest sum of elements has an index ---> {RowMinSumElements(userMatrix) + 1}");
Console.WriteLine();