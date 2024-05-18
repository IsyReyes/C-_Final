using System;

public static class MatrixGenerator
{
    public static int[,] GenerateMatrix(int rows, int cols, int minValue = 1, int maxValue = 100)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue); // Random numbers between minValue and maxValue
            }
        }

        return matrix;
    }
}
