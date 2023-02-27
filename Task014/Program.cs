
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] GenerateArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
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

int ShowNumberEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int size = 4;
int[] array = GenerateArray(size);
Console.WriteLine();
Console.WriteLine("Number even elements in array");
ShowArray(array); 
Console.Write($" --> {ShowNumberEvenElements(array)}");