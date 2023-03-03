// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int InputInt(string message)
{
    Console.Write($"{message}> ");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("Error! Incorrect value.");
    Environment.Exit(1);
    return 0;
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

int [] EnterArrayNumbers (int size)
{
    int [] array = new int [size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputInt($"Enter array element at index {i}");
    }
    return array;
}

int CountPositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int size = InputInt("Enter size array");
int [] array = EnterArrayNumbers(size);
Console.WriteLine("Number of positive numbers in array");
ShowArray(array);
Console.WriteLine($" ---> {CountPositiveNumbers(array)}");