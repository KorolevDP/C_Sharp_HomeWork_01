// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputInt(string message)
{
    Console.Write($"{message}> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("Error. Incorrect value");
    Environment.Exit(1);
    return 0;
}

int SumOfNumbers(int number)
{
    int Sum = 0;
    
    for(int i = 1; number > 0; i++)
    {
        Sum += number % 10;
        number /= 10;
    }
    return Sum;
}

int number = InputInt("Enter number");
Console.Write($"In number {number}, summ of numbers  = {SumOfNumbers(number)}");