// Вывести на экран массив из 8 элементов в виде: [1,2,5,7,19]
Console.Write("Введите комбинацию цифр через запятую: ");
string a = Console.ReadLine();
string s = string.Join(",", a); // определяем метод вывода 
Console.WriteLine($"[{s}]");
