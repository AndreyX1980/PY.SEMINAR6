//Показать все четные числа от 1 до N
Console.WriteLine("Показать все четные числа от 1 до a:");
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
for (int x = 2; x < a; x++)       
if (x%2==0)            
Console.WriteLine(x);