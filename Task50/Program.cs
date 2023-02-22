// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

void Main()
{
    Console.Clear();
    int[,] matrix = GetArray(8, 8, -9, 9);
    PrintArray(matrix);
    Console.WriteLine("Введите позицию строки: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите позицию столбца: ");
    int col = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    OutPutElement(matrix, row, col);
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] intArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return intArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void OutPutElement(int[,] array, int rowEl, int colEl)
{
    int x = array.GetLength(0) - 1;
    int y = array.GetLength(1) - 1;
    if (rowEl > x || colEl > y)
    {
        Console.WriteLine("Такого числа в массиве нет ");
    }
    else
    {
        Console.WriteLine(array[rowEl, colEl]);
    }
}

Main();