// двумерный массив с одинаковым кол-вом столбцов и строк, Найти строку с min sum элементов

var a = new Int32[4, 4];
var random = new Random();
for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
{
    for (var j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.Next(100);
        Console.Write("{0,4}", a[i, j]);
    }
}
Console.WriteLine("---");


int minRowSum = int.MaxValue, indexMinRow = 0;
for (int i = 0; i < 4; i++)
{
    int rowSum = 0;
    for (int j = 0; j < 4; j++)
        rowSum += a[i, j];
    
    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}
/*Console.WriteLine("Значения строки с минимальной суммой элементов:");
    for(int j = 0;j<4;j++)
        Console.Write(a[indexMinRow, j] + "\t");
Console.WriteLine();
*/Console.WriteLine("Номер строки с минимальной суммой элементов:");
Console.WriteLine(indexMinRow + 1);