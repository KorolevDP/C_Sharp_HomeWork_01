//Напишите программу, которая на вход принимает два числа и выдает, какое число большеe, а какое меньшее.

int Promt(string message)
{
    Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
  
int value1 = Promt("Enter first number");
int value2 = Promt("Enter second number");

int max = 0;
int min = 0;

if (value1 > value2)
{
    max = value1; 
    min = value2;    
}
else
{
    max = value2; 
    min = value1;    
}

Console.Write($"Max value >{max}\nMin value >{min}");
