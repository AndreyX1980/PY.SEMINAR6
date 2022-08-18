// Расстояние меду двумя точками в 3D пространстве (из координат)
// точка A (), точка B (), точка С ()
// формула вычисления расстояниямежду двумя точками в пространстве AB = корень _(xb-xa)квадр+(yb-ya)квадр+(zb-za)квадр_


char selection;
Double x1, x2, y1, y2, z1, z2, distance;
    //Console.WriteLine("1. Расстояние между двумя точками на плоскости.");
    Console.WriteLine("Найдем расстояние между двумя точками в пространстве.");
    //Console.WriteLine(2);
// Предусмотрено еще нахождение расстояния на плоскости в case 1
    selection = '2'; //Convert.ToChar(2);

    switch (selection)
    {
        /*case '1':
            Console.Write("Введите координаты x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
            Console.ReadKey();
            break;*/
        case '2':
            Console.Write("Введите координаты x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты z1: ");
            z1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты z2: ");
            z2 = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Вы ввели неверный символ");
            Console.ReadKey();
            break;
    }

