// создать двумерный случайный массив (-10;10). Найти сумму чисел в главной диагонали.
Console.WriteLine("Создаем случайный массив!");
int[] a = new int[4];
Random  rand1 = new Random();
for(int i = 0; i < a.Length; i++)
    a[i] = rand1.Next(-10, 10);
int[] b = new int[4];
Random  rand2 = new Random();
for(int i = 0; i < b.Length; i++)
    b[i] = rand2.Next(-10, 10);
int[] c = new int[4];
Random  rand3 = new Random();
for(int i = 0; i < c.Length; i++)
    c[i] = rand3.Next(-10, 10);
string s = string.Join("  ", a);
    Console.Write($"{s} ");

string s1 = string.Join("  ", b);
    Console.Write($"\n{s1} ");

string s2 = string.Join("  ", c);
    Console.Write($"\n{s2} ");

Console.WriteLine($"\nСумма главной диагонали массива: {a[0]} + {b[1]} + {c[2]} = {a[0]+b[1]+c[2]}");