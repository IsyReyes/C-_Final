using System;
using System.Collections.Generic;
using ConsoleTables;

public class MatrixExercises
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

        int[,] resultMatrix = MultiplyByTwo(multiplyMatrix);

        PrintMatrix(resultMatrix);
    }

    public static int[,] MultiplyByTwo(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * 2;
            }
        }

        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        var columnNames = new List<string>();
        for (int i = 0; i < cols; i++)
        {
            columnNames.Add($"Col {i + 1}");
        }

        var table = new ConsoleTable(columnNames.ToArray());

        for (int i = 0; i < rows; i++)
        {
            var row = new object[cols];
            for (int j = 0; j < cols; j++)
            {
                row[j] = matrix[i, j];
            }
            table.AddRow(row);
        }
        table.Write();
    }

    public static int[,] CreateAndFillMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 100); // Random numbers between 1 and 99
            }
        }

        return matrix;
    }

    public static int[] CalculateColumnSums(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] columnSums = new int[cols];

        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                columnSums[j] += matrix[i, j];
            }
        }

        return columnSums;
    }

    public static int GetHighestSumColumn(int[] columnSums)
    {
        int maxSum = columnSums[0];
        int maxIndex = 0;

        for (int i = 1; i < columnSums.Length; i++)
        {
            if (columnSums[i] > maxSum)
            {
                maxSum = columnSums[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    public static void TestRandomMatrix()
    {
        int[,] randomMatrix = CreateAndFillMatrix(20, 20);
        PrintMatrix(randomMatrix);
        int[] columnSums = CalculateColumnSums(randomMatrix);
        int highestSumColumn = GetHighestSumColumn(columnSums);
        Console.WriteLine($"La columna con la suma más alta es: Columna {highestSumColumn + 1} con una suma de {columnSums[highestSumColumn]}");
    }

    public static void AnalyzeLargeMatrix()
    {
        int[,] matrix = CreateAndFillMatrix(100, 100);
        PrintMatrix(matrix);

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

    public static int[,] GenerateMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }

        return matrix;
    }

    public static int[] CalculateRowSums(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] rowSums = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rowSums[i] += matrix[i, j];
            }
        }

        return rowSums;
    }

    public static void PrintMatrixWithSums(int[,] matrix, int[] rowSums, int[] columnSums)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        Console.WriteLine("Matriz y suma de filas (Arreglo B):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine("| " + rowSums[i]);
        }

        Console.WriteLine("Suma de columnas (Arreglo A):");
        for (int j = 0; j < cols; j++)
        {
            Console.Write(columnSums[j] + "\t");
        }
        Console.WriteLine();
    }

    public static void GenerateAndAnalyzeMatrix()
    {
        int[,] matrix = GenerateMatrix(10, 10);
        int[] rowSums = CalculateRowSums(matrix);
        int[] columnSums = CalculateColumnSums(matrix);
        PrintMatrixWithSums(matrix, rowSums, columnSums);
    }

    public static void GenerateAndSwapColumns()
    {
        int[,] matrix = GenerateMatrix(10, 10);

        Console.WriteLine("Matriz Original:");
        PrintMatrix(matrix);

        SwapFirstAndLastColumns(matrix);

        Console.WriteLine("Matriz después de intercambiar la última y la última columna:");
        PrintMatrix(matrix);
    }

    public static void SwapFirstAndLastColumns(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, 0];
            matrix[i, 0] = matrix[i, cols - 1];
            matrix[i, cols - 1] = temp;
        }
    }


    public static int FindMaxValue(int[,] matrix)
    {
        int maxValue = matrix[0, 0];
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxValue)
                {
                    maxValue = matrix[i, j];
                }
            }
        }

        return maxValue;
    }

    public static int[] FindMaxInEachRow(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] maxInRows = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int maxInRow = matrix[i, 0];
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] > maxInRow)
                {
                    maxInRow = matrix[i, j];
                }
            }
            maxInRows[i] = maxInRow;
        }

        return maxInRows;
    }

    public static int FindColumnWithMaxSum(int[,] matrix)
    {
        int[] columnSums = CalculateColumnSums(matrix);
        return GetHighestSumColumn(columnSums);
    }

    public static int FindRowWithMaxSum(int[,] matrix)
    {
        int[] rowSums = CalculateRowSums(matrix);
        int maxSum = rowSums[0];
        int maxIndex = 0;

        for (int i = 1; i < rowSums.Length; i++)
        {
            if (rowSums[i] > maxSum)
            {
                maxSum = rowSums[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    public static void GenerateAndAnalyzeMatrixExtended()
    {
        int[,] matrix = GenerateMatrix(10, 10);
        PrintMatrix(matrix);

        int maxValue = FindMaxValue(matrix);
        Console.WriteLine($"Valor máximo en la matriz: {maxValue}");

        int[] maxInRows = FindMaxInEachRow(matrix);
        Console.WriteLine("Valor máximo por fila:");
        for (int i = 0; i < maxInRows.Length; i++)
        {
            Console.WriteLine($"Row {i + 1}: {maxInRows[i]}");
        }

        int maxSumColumn = FindColumnWithMaxSum(matrix);
        Console.WriteLine($"Columna con la suma más alta: {maxSumColumn + 1}");

        int maxSumRow = FindRowWithMaxSum(matrix);
        Console.WriteLine($"Fila con la suma más alta: {maxSumRow + 1}");
    }
}


