//Показать вторую цифру трехзначного числа
Console.WriteLine("Ожидаю трехзначное число.Для завершения работы-Exit.");
//можно еще включить проверку на количество введенных символов
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }