// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y= k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, 
// b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);


double Promt(string message)
{
    Console.Write($"{message}> ");
    double value;
    if(double.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("Error! Incorrect value.");
    Environment.Exit(1);
    return 0;
}

// Ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2]; 
    lineData[COEFFICIENT] = Promt($"Enter coefficient for {numberOfLine} line >");
    lineData[CONSTANT] = Promt($"Enter constant for {numberOfLine} line >");
    return lineData;
}

// Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
    return coord;
}

// Проверка прямых
bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Lines coincide");
            return false;
        }
        else
        {
            Console.WriteLine("Lines parallel");
            return false;
        }
    }
    return true;
}

if (ValidateLines(lineData1, lineData2))
{
    double coord = FindCoords(lineData1, lineData2);
    Console.Write($"Equation intersection point y = {lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} и y = {lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]}");
    Console.WriteLine($"has coordinates ({coord[X_COORD]}, {coord[Y_COORD]})");
}