//Какое из двух чисел максимальное?(5,7; 2,10; -9,-3)
Console.WriteLine("Введите по очереди два числа, чтобы узнать, какое из них больше: ");
var n1 = Decimal.Parse(Console.ReadLine());
            var n2 = Decimal.Parse(Console.ReadLine());
            if (n1 > n2)
                Console.WriteLine(n1);
            else 
                Console.WriteLine(n2);