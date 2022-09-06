// Задать M и N. Вывести в консоль сумму натуральных элементов от M до N.

Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число M:");
int numberN = int.Parse(Console.ReadLine());

void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine("Сумма натуральных элементов в промежутке от M до N:");
        Console.WriteLine($"{sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);