// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    int col = int.Parse(Console.ReadLine()!);

    double[,] matrix = GetArray(row, col, 9);
    PrintArray(matrix);
}



double[,] GetArray(int m, int n, int maxValue)
{
    double[,] intArray = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().NextDouble()*maxValue;
        }
    }
    return intArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1}\t ");
        }
        Console.WriteLine();
    }
}

Main();