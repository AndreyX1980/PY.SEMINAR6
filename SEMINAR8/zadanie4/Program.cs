// трехмерный массив неповторяющихся двузначных чисел. Вывести построчно массив с индексом каждого элемента.

int[,,] GenerateTripleArr(int nx = 2, int ny = 2, int nz = 2)
{
    int[,,] tripleArr = new int[nx, ny, nz];
    int val;
    List<int> vals = new List<int>();
    Random rnd = new Random();
    for (int x = 0; x < nx; x++)
    {
        for (int y = 0; y < ny; y++)
        {
            for (int z = 0; z < nz; z++)
            {
                do val = rnd.Next(10,100); 
                while (vals.Contains(val));
                tripleArr[x, y, z] = val;
                vals.Add(val);
            }
        }
    }
    return tripleArr;
}

void PrintTripleArr(int[,,] arr)
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                Console.Write($"{arr[x, y, z]}: [{x}, {y}, {z}]\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
PrintTripleArr(GenerateTripleArr());
