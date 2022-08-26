// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[linesVol, columnsVol];
CreateMatrix(numbers);
PrintMatrix(numbers);

void CreateMatrix(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintMatrix(double[,] arr)
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
