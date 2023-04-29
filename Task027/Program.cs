// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

// m = 3, n = 2 -> A(m,n) = 29

int FunctionAckermann(int m, int n)
{       
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunctionAckermann(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));       
    return FunctionAckermann(m,n);
}

int m = 2, n = 3;
Console.WriteLine();
Console.Write($"m = {m}, n = {n} ---> {FunctionAckermann(m,n)}");
Console.WriteLine("\n");