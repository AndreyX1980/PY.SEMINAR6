//Какое из трех чисел максимальное?(2,3,7; 44,5,78; 22,3,9)
Console.WriteLine("Определяем максимальное из трех чисел:");
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c:");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (b > max)
    max = b;
if (a > max)
    max = a;
if (c > max)
    max = c;
    Console.WriteLine("max число:");
    Console.WriteLine(max);