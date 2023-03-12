// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            array[i,j] = rnd.Next(1, 6);
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

int[,] ProductMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
	    for(int j = 0; j < matrixB.GetLength(1); j++)
	    {
	       for (int k = 0; k < matrixA.GetLength(1); k++)
	       {
	        matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
	       }
	    }
    }
    return matrixC;
}

Console.WriteLine();
int rowA = InputInt("Enter number rows in matrix A");
int colA = InputInt("Enter number columns in matrix A");
Console.WriteLine();
int rowB = InputInt("Enter number rows in matrix B");
int colB = InputInt("Enter number columns in matrix B");
int[,]matrixA = GenerateMatrix(rowA, colA);
int[,]matrixB = GenerateMatrix(rowB, colB);
Console.WriteLine();
Console.WriteLine("Matrix A");
PrintMatrix(matrixA);
Console.WriteLine("----------------------------------");
Console.WriteLine("Matrix B");
PrintMatrix(matrixB);
int[,] matrixC = ProductMatrix(matrixA, matrixB);
Console.WriteLine();
Console.WriteLine("----------------------------------");
Console.WriteLine("Product matrix A and matrix B");
PrintMatrix(matrixC);