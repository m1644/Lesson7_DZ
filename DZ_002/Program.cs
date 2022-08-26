// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5, 0, 99);

Console.Write("Введите строку:");
int cor1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:");
int cor2 = Convert.ToInt32(Console.ReadLine()) - 1;

PrintMatrix(matrix);

if (cor1 < 0 | cor1 > matrix.GetLength(0) - 1 | cor2 < 0 | cor2 > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует!");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[cor1, cor2]);
}
