//Палиндромы
Console.WriteLine("Введите исследуемую комбинацию(пять символов):");
string s = Console.ReadLine();
if (s[0] == s[4] && s[1] == s[3])
{
    Console.WriteLine("Это палиндром!");
}
else
{
    Console.WriteLine("Это НЕ палиндром!");
}