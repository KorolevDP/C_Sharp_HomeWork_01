// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом. Проверка без применения строк.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputInt(string message)
{
    Console.Write($"{message}> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("You enter not number");
    Environment.Exit(1);
    return 0;
}

bool checkPalindrome(int num)
{
    int number = num;
    int rev = 0;

    while (number > 0)
    {
        int takenDigit = number % 10;
        rev = rev * 10 + takenDigit;
        number /= 10;
    }
    return (num == rev);
}

int number = InputInt("Enter number");

if (checkPalindrome(number))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}