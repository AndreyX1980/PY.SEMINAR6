// вычислить функцию АККермана

int m = ReadInt("Введите натуральное число M: ");
int n = ReadInt("Введите натуральное число N: ");

int ReadInt(string msg)
{
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out int num) || num < 1) ReadInt(msg);
    return num;
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.Write($"Результат: {Ackermann(m, n)}");
Console.WriteLine();

