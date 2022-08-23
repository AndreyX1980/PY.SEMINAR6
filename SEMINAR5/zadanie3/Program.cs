// массив вещественных чисел.Разница между max и min элементами
Double[] a = new Double[5];
int i;
Random  rand = new Random();
for(i = 0; i < a.Length; i++)
    a[i] = rand.Next(0, 100) / 10.0;
    double max = a[0];
    double min = a[0];
for(i = 0; i < a.Length; i++)
 {
    if(a[i]>max)
    {
        max = a[i];
    }
    if(a[i]<min) 
    {
        min = a[i];
    }
 }
string s = String.Join(";",a);
Console.Write($"Массив: [{s}] ");
Console.WriteLine($" {(max)} - {(min)} = {max-min}");
