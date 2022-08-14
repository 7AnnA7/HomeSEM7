// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] Matrix = FillMatrixRandomNumbers(m,n);
PrintMatrix(Matrix);

double[,] FillMatrixRandomNumbers(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    int max = 100;
    int min = -100;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
            matrix[i, j] = Math.Round(rand.NextDouble()*(max - min) + min, 1);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
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