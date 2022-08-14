// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер строки в двумерном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца в двумерном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = FillArray(10, 10);
PrintArray(randomArray);
Console.WriteLine();
FindElementPosition(randomArray, m, n);

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElementPosition(int[,] array, int Row, int Column)
{
 if (Row < array.GetLength(0) && Column < array.GetLength(1))
  {
    Console.WriteLine($"На позиции строка {Row}, столбец {Column} находится элемент со значением {array[Row - 1, Column - 1]}");
  }
 else Console.WriteLine($"На строке {Row}, столбец {Column} элемента в массиве нет.");
}

