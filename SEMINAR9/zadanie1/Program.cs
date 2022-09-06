// Задать M и N. Вывести в консоль все натуральные числа от M до N.

int M = ReadInt("Введите натуральное число M: ");
int N = ReadInt("Введите натуральное число N: ");
int ReadInt(string msg)
{        
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out int num) || num < 1) ReadInt(msg);
    return num;
}

void PrintNaturals(int M, int N)
{
    Console.Write($"{M} ");
    if (M == N) return;
    if (M < N) M++; else M--;
    PrintNaturals(M, N);
}

Console.WriteLine("Натуральные числа в промежутке от M до N:");
PrintNaturals(M, N);
Console.WriteLine();