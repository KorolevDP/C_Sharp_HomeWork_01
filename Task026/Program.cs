// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNumbersOfRange(int first, int second)
{       
    if (first > second) return 0;
    return first + SumNumbersOfRange(first + 1, second);       
}

int num = 1, second = 16;
Console.WriteLine();
Console.Write($"M = {num}; N = {second} ---> {SumNumbersOfRange(num, second)}");
Console.WriteLine("\n");