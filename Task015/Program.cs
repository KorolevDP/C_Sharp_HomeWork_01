// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

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

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int SumOddElements(int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        Sum += array[i];
    }
    return Sum;
}

int size = InputInt("Enter size array:");
int minValue = InputInt("Enter minimal value for randomize:");
int maxValue = InputInt("Enter maximum value for randomize:");
int[] array = GenerateArray(size, minValue, maxValue);
Console.WriteLine();
Console.WriteLine("Sum of elements at odd positions");
ShowArray(array); 
Console.Write($" --> {SumOddElements(array)}");