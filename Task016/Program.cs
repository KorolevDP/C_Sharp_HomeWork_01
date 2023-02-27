// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3, 7.4, 22.3, 2, 78] -> 76

int InputInt(string message)
{
    Console.Write($"{message}> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("You enter not number");
    Environment.Exit(1);
    return 0;
}

double[] GenerateArray(int size)
{
    double[] result = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100) + Math.Round(rnd.NextDouble(), 2);
    }
    return result;
}

void ShowArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ;  ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

double DifMaxMin(double[] array)
{
    double Max = array[0];
    double Min = array[0];
    double Dif = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
        if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    return Dif = Max - Min;
}

int size = InputInt("Enter size array:");
double[] array = GenerateArray(size);
Console.WriteLine();
Console.WriteLine("Difference between the maximum and minimum elements");
ShowArray(array); Console.Write($" --> {DifMaxMin(array)}");