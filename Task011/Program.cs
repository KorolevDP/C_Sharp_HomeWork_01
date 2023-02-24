// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

int GetPower(int number, int power)
{
    int Result = 1;
    for (int i = 1; i <= power; i++)
    {
        Result *= number ;
    }
    return Result;
}

int number = InputInt("Enter number");
int power = InputInt("Enter power of number");

Console.Write($"Number {number} in power {power} = {GetPower(number, power)}");