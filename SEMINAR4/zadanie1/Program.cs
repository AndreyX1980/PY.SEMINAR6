//Возведение числа А в натуральную степень В
int i=0;
while(i<2)
{
    Console.WriteLine("Введите число A: "); //подготовить строку для ввода числа A
    int A = Convert.ToInt32(Console.ReadLine()); //объявить переменную A
    Console.WriteLine("Введите число B(степень числа): "); //подготовить строку для ввода числа B (натуральная степень)
    int B = Convert.ToInt32(Console.ReadLine()); //объявить переменную B

    Console.WriteLine($"Степень числа: {Math.Pow(A,B)}"); //записать формулу возвведения в степень
    i++;
    Console.WriteLine($"------------------------");
}
Console.WriteLine($"end");