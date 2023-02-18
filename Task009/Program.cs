// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt(string message)
{
    Console.Write($"{message}> ");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("You enter not number");
    Environment.Exit(1);
    return 0;
}

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    return Math.Sqrt(Math.Pow(deltaX,2) + Math.Pow(deltaY,2) + Math.Pow(deltaZ,2));
}

int x1 = InputInt("Enter X1 of first dot ");
int y1 = InputInt("Enter Y1 of first dot ");
int z1 = InputInt("Enter Z1 of first dot ");
int x2 = InputInt("Enter X2 of second dot ");
int y2 = InputInt("Enter Y2 of second dot ");
int z2 = InputInt("Enter Z2 of second dot ");

Console.WriteLine($"Distance between dot A({x1}, {y1}, {z1}) and dot B({x2}, {y2}, {z2}) equal {Distance (x1, y1, z1, x2, y2, z2)}");