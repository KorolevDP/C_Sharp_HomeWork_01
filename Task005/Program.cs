// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Promt(string msg)
{
    Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if(100 <= num && num < 1000)
    {
        return true;
    }
    Console.WriteLine("This number is not three digits.");
    return false;
}

int number = Promt("Enter three-digit number");

if(Validate(number))
{
    int secondDigit = number / 10 % 10;
    Console.WriteLine($"Second digit of number {number} is {secondDigit}");
}
