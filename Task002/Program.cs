//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

int[] arrayNumbers = new int[3];
int maxValue = arrayNumbers[0];

for (int i =0; i < 3; i++)
{
    Console.Write($"Enter number {i+1}:\t ");
    arrayNumbers[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 3; i++)
{
    if(arrayNumbers[i] > maxValue)
    {
        maxValue = arrayNumbers[i];
    }
}

Console.Write($"Max number = {maxValue}");