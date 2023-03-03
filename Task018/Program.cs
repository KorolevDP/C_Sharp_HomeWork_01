// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y= k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, 
// b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = Promt($"Enter value b1 ");
double k1 = Promt($"Enter value k1 ");
double b2 = Promt($"Enter value b2 ");
double k2 = Promt($"Enter value k2 ");
(double x, double y) = FindX(b1, b2, k1, k2);

Console.WriteLine($"Coords = ({x:F2}, {y:F2})");

int Promt(string message)
{
    Console.Write($"{message}> ");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("Error! Incorrect value.");
    Environment.Exit(1);
    return 0;
}

(double, double) FindX (double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}