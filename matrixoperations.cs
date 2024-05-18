public static class MatrixOperations
{
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
}
