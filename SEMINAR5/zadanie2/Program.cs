// массив случайных чисел. Показать сумму нечетных позиций элементов 
int[] a = new int[5];
int i;
int sum = 0;
Random  rand = new Random();
for(i = 0; i < a.Length; i++)
    a[i] = rand.Next(-10,10);

for(i = 0; i < a.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + a[i];
    }
}
string s = String.Join(",",a);
    Console.Write($"Массив: [{s}] ");
Console.WriteLine($" -> Сумма нечетных позиций чисел: {sum}"); 

