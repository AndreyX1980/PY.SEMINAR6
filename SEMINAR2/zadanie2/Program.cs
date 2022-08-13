//Вывести на экран третью цифру, или сообщить, что её нет.
Console.WriteLine("Ищем третью цифру в комбинации");
Console.Write("Введите комбинацию цифр: ");
int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
//Console.WriteLine("Третья цифра:");
Console.WriteLine(k < 0 ? "Введенная комбинация содержит менее трех символов!" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
