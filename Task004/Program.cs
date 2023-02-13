// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.

Console.Write("Enter your number >");
int number = int.Parse(Console.ReadLine());

for(int i = 2; i <= number; i++ )
{
    if(i % 2 ==0)
    {
        Console.Write($"{i}, ");
    }
}