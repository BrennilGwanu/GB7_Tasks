// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

void Main()
{
Console.Clear();
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(row, col, 0, 10);
PrintArray(matrix);
AverageInCol(matrix);
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

void AverageInCol(int[,] array)
{
    Console.WriteLine("Среднее арифметическое элементов: ");
    int rowEl = array.GetLength(0);
    int colEl = array.GetLength(1);
    for (int i = 0; i < colEl; i++)
    {
        double sum = 0;
        for (int j = 0; j < rowEl; j++)
        {
            sum += array[j, i];
        }
        double average = sum / rowEl;
        Console.WriteLine($"{i+1} столбец - {average:f1}");
    }
}

Main();