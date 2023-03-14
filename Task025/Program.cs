// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void ShowEvenNumbers(int first, int second)
{
    if (first > second) return;
    if (first % 2 == 0) Console.Write($"{first}, ");
    ShowEvenNumbers(first + 1, second);
}

int num = 1, second = 19;
Console.WriteLine();
Console.Write($"M = {num}; N = {second} ---> ");
ShowEvenNumbers(num, second);
Console.WriteLine("\n");