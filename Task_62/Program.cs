// Заполнить спирально массив 4 на 4

int rows = 4;
int columns = 4;
int[,] matrix(int m, int n)
{
    int[,] matrix = new int[rows, columns];
    int t = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            while (t <= columns * rows)
            {
                matrix[i, j] = t;

                if (i <= j + 1 && i + j < columns - 1) j++;
                else if (i < j && i + j >= rows - 1) i++;
                else if (i >= j && i + j > columns - 1) j--;
                else i--;
                t++;
            }
        }

    }
    return matrix;

}
int[,] result = matrix(rows, columns);


void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write($"0{matrix[i, j]} ");

            else Console.Write($"{matrix[i, j]} ");


        }
        Console.WriteLine();
    }
}
Print(result);
