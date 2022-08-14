// Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = FillMatrixRandomNumbers(m,n);
Console.WriteLine();
PrintMatrix(Matrix);
Console.WriteLine();
Console.Write("Среднее арифметическое по столбцам: ");
FindAverage(Matrix);

int[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindAverage(int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        average = average / array.GetLength(0);
        // average = Math.Round(average / array.GetLength(0), 1, MidpointRounding.ToZero); - так от лишних символов
        // после запятой избавляться?
        
        Console.Write($"{average}; ");
        average = 0;
    }
}
