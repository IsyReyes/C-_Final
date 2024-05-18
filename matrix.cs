using System;
using System.Collections.Generic;
using ConsoleTables;

public class MatrixExercises{
    public static void ChessBoard(){
        string[] fields = { "N", "B" };

        for (int i = 0; i < 8; i++){
            if (i % 2 == 0){
                for (int j = 0; j < 4; j++){
                    Console.Write(string.Join("", fields[0], fields[1]));
                }
            }else{
                for (int j = 0; j < 4; j++){
                    Console.Write(string.Join("", fields[1], fields[0]));
                }
            }
            Console.WriteLine();
        }
    }

    public static void MatrixBig(){
        int[,] multiplyMatrix = new int[,] {
            { 5, 6, 13 },
            { 14, 2, 4 },
            { 21, 7, 6 }
        };

        int[,] resultMatrix = MultiplyByTwo(multiplyMatrix);

        PrintMatrix(resultMatrix);
    }

    public static int[,] MultiplyByTwo(int[,] matrix){
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
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
        for (int i = 0; i < cols; i++){
            columnNames.Add($"Col {i + 1}");
        }

        var table = new ConsoleTable(columnNames.ToArray());

        for (int i = 0; i < rows; i++){
            var row = new object[cols];
            for (int j = 0; j < cols; j++){
                row[j] = matrix[i, j];
            }
            table.AddRow(row);
        }
        table.Write();
    }
}

