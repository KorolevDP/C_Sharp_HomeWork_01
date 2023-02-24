// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputSizeArray(string msg)
{
    Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

int[] fillArray (int sizeArray)
{    
    int[] array = new int[sizeArray];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,20);
    }
    return array;
}

void printArray(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int SizeArray = InputSizeArray("Enter size array");
int [] array =  fillArray(SizeArray);
printArray(array);