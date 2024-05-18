using System;

public static class MatrixExercises
{
    public static void ChessBoard()
    {
        string[] fields = { "N", "B" };

        for (int i = 0; i < 8; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(string.Join("", fields[0], fields[1]));
                }
            }
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(string.Join("", fields[1], fields[0]));
                }
            }
            Console.WriteLine();
        }
    }

    public static void MatrixBig()
    {
        int[,] multiplyMatrix = new int[,] {
            { 5, 6, 13 },
            { 14, 2, 4 },
            { 21, 7, 6 }
        };

        int[,] resultMatrix = MatrixOperations.MultiplyByTwo(multiplyMatrix);

        MatrixPrinter.PrintMatrix(resultMatrix);
    }

    public static void TestRandomMatrix()
    {
        int[,] randomMatrix = MatrixGenerator.GenerateMatrix(20, 20);
        MatrixPrinter.PrintMatrix(randomMatrix);
        int[] columnSums = MatrixOperations.CalculateColumnSums(randomMatrix);
        int highestSumColumn = MatrixOperations.GetHighestSumColumn(columnSums);
        Console.WriteLine($"La columna con la suma más alta es: Columna {highestSumColumn + 1} con una suma de {columnSums[highestSumColumn]}");
    }

    public static void AnalyzeLargeMatrix()
    {
        int[,] matrix = MatrixGenerator.GenerateMatrix(100, 100);
        MatrixPrinter.PrintMatrix(matrix);

        int sum = 0;
        int count = 0;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[i, j];
                count++;
            }
        }

        double average = (double)sum / count;
        Console.WriteLine($"Average: {average}");

        int sumOddBelowAvg = 0;
        int sumEvenAboveAvg = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int value = matrix[i, j];
                if (value < average && value % 2 != 0)
                {
                    sumOddBelowAvg += value;
                }
                else if (value > average && value % 2 == 0)
                {
                    sumEvenAboveAvg += value;
                }
            }
        }

        Console.WriteLine($"Suma de números por debajo del promedio (Impares): {sumOddBelowAvg}");
        Console.WriteLine($"Suma de números por arriba del promedio (Pares): {sumEvenAboveAvg}");
    }

    public static void GenerateAndAnalyzeMatrix()
    {
        int[,] matrix = MatrixGenerator.GenerateMatrix(10, 10);
        int[] rowSums = MatrixOperations.CalculateRowSums(matrix);
        int[] columnSums = MatrixOperations.CalculateColumnSums(matrix);
        MatrixPrinter.PrintMatrixWithSums(matrix, rowSums, columnSums);
    }

    public static void GenerateAndSwapColumns()
    {
        int[,] matrix = MatrixGenerator.GenerateMatrix(10, 10);

        Console.WriteLine("Matriz Original:");
        MatrixPrinter.PrintMatrix(matrix);

        MatrixOperations.SwapFirstAndLastColumns(matrix);

        Console.WriteLine("Matriz después de intercambiar la última y la última columna:");
        MatrixPrinter.PrintMatrix(matrix);
    }

    public static void GenerateAndAnalyzeMatrixExtended()
    {
        int[,] matrix = MatrixGenerator.GenerateMatrix(10, 10);
        MatrixPrinter.PrintMatrix(matrix);

        int maxValue = MatrixOperations.FindMaxValue(matrix);
        Console.WriteLine($"Valor máximo en la matriz: {maxValue}");

        int[] maxInRows = MatrixOperations.FindMaxInEachRow(matrix);
        Console.WriteLine("Valor máximo por fila:");
        for (int i = 0; i < maxInRows.Length; i++)
        {
            Console.WriteLine($"Row {i + 1}: {maxInRows[i]}");
        }

        int maxSumColumn = MatrixOperations.FindColumnWithMaxSum(matrix);
        Console.WriteLine($"Columna con la suma más alta: {maxSumColumn + 1}");

        int maxSumRow = MatrixOperations.FindRowWithMaxSum(matrix);
        Console.WriteLine($"Fila con la suma más alta: {maxSumRow + 1}");
    }
}
