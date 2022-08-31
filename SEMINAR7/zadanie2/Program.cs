// есть массив, проверить, есть ли в нем вводимое из консоли число. Вывести его индекс/ сказать -нет.

/*using System;
 
public static class Extensions
{
    public static int findIndex<T>(this T[] array, T item) {
        return Array.IndexOf(array, item);
    }
}
 
public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int item = Console.ReadLine("Введите число: ");
 
        int index = array.findIndex(item);
        if (index != -1) {
            Console.WriteLine(String.Format("Element {0} is found at index {1}", item, index));
        }
        else {
            Console.WriteLine("Element not found in the given array.");
        }
    }
}
*/

Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3, 4];

void FillArr(int[,] matr)
{
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {                    
            matr[i, j] = new Random().Next(1,10); 
            Console.Write($"{matr[i, j]}  ");
         }    
    Console.WriteLine();
    }
}

void IndexArr(int[,] arr, int n)
{  
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        if(arr[i,j]==n)
        {
           Console.WriteLine($"Индексы элемента: {(i, j)}"); 
           break;
        }
    }
}

FillArr(matrix);
IndexArr(matrix, n);
