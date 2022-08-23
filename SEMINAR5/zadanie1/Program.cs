// массив случайных трехзначных чисел. Показать количество четных чисел
int[] a = new int[5];
int i = 0;
//int a_2 = 0;
Random  rand = new Random();
for(i = 0; i < a.Length; i++)
    a[i] = rand.Next(100, 999);
int a_2 = 0;
for (i = 0; i < a.Length; i++)
 {
    if((a[i] % 2)==0)
    {
        a_2 = a_2 + 1;
    }
 }
string s = String.Join(",",a);
    Console.Write($"Массив: [{s}] ");
 Console.WriteLine($" -> Кол-во четных чисел: {a_2}");