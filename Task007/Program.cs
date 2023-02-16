// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Promt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if(1 <= num && num <= 7)
    {
        return true;
    }
    Console.WriteLine("This number invalid.");
    return false;
}

int number = Promt("Enter number (1-7)");

if(Validate(number))
{
    if(number == 6 || number == 7)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }   
}