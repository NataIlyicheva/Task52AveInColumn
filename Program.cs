// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] InitMatrix(int m, int n)
{
    int [,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(0, 10);
        }
    }
    return resultMatrix;
}    

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}      ");
        }
        Console.WriteLine();
    }
}

void FindAverage (int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double colSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            colSum += matrix[i, j];
        }
    colSum = Math.Round((colSum / matrix.GetLength(0)),1);
    Console.Write(colSum + "   |   "  );
    }
}

int[,] matrix = InitMatrix(3,4);
PrintMatrix(matrix);
Console.WriteLine("______________________");
Console.WriteLine();
FindAverage(matrix);
Console.WriteLine();