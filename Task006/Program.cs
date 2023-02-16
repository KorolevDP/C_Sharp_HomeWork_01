// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Promt(string msg)
{
    Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Promt("Enter number");
int result = 0;

if (number >= 100)
{
    while(number > 999)
    {
        number /= 10; 
    }
    result = number % 10;
    Console.Write($"Third digit >{result}");
}
else 
{
    Console.Write("No third digit");
}
