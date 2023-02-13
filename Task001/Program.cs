//Напишите программу, которая на вход принимает два числа и выдает, какое число большеe, а какое меньшее.

Console.Write("Enter first number  >");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number >");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.Write($"max = {number1} \nmin = {number2}");    
}
else
{
    Console.Write($"max = {number2} \nmin = {number1}"); 
}
