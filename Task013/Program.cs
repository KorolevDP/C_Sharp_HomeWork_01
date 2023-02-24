// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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

int[] fillArray (int sizeArray, int minValue, int maxValue)
{    
    int[] array = new int[sizeArray];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue,maxValue + 1);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");   
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
int min = InputInt("Enter min of random");
int max = InputInt("Enter max of random");
int SizeArray = InputInt("Enter size array");
int [] array =  fillArray(SizeArray, min, max);
printArray(array);