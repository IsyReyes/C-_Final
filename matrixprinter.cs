using System;
using System.Collections.Generic;
using ConsoleTables;

public static class MatrixPrinter
{
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
}
