// Проверить соответствие номера дня недели выходному дню
Console.WriteLine("Число - день недели - Рабочий/Выходной");
Console.Write("Введите число: ");
int num = Convert.ToInt16(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Нет-Рабочий день(("); break;
    case 2: Console.WriteLine("Нет-Рабочий день(("); break;
    case 3: Console.WriteLine("Нет-Рабочий день(("); break;
    case 4: Console.WriteLine("Нет-Рабочий день(("); break;
    case 5: Console.WriteLine("нет-Рабочий день(("); break;
    case 6: Console.WriteLine("ДА!-выходной"); break;
    case 7: Console.WriteLine("ДА!-выходной"); break;
    default: Console.WriteLine("Ожидалось от 1 до 7"); break;
}
