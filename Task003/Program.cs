// Напишите программу, которая на вход принимает число и выдает, является ли число четным.

Console.Write("Enter number ");
int number = int.Parse(Console.ReadLine());

if(number % 2 ==0)
{
    Console.WriteLine($"Number {number} even");
}
else
{
    Console.WriteLine($"Number {number} odd");
}
