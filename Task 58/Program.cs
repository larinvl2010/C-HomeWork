// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] Fill2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine("Enter array[" + i + "," + j + "] : ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}
void ProductOfMatrices(int[,] arrayA, int[,] arrayB)
{
    if (arrayA.GetLength(0) == arrayB.GetLength(1))
    {
        int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
        int sum = 0;
        Console.WriteLine("The product of matrix A by matrix B");

        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    sum += arrayA[i, k] * arrayB[k, j];
                }
                Console.Write(sum + "\t");
                sum = 0;

            }
            Console.WriteLine();
        }

    }
    else
        Console.WriteLine("The number of columns of the first matrix should be equal to the number of rows of the second matrix");
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Enter the number of rows of the first matrix");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the first matrix");
int columnsA = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = Fill2DArray(rowsA, columnsA);
Console.WriteLine("Enter the number of rows of the second matrix");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns of the second matrix");
int columnsB = Convert.ToInt32(Console.ReadLine());
int[,] matrixB = Fill2DArray(rowsB, columnsB);
Console.WriteLine("The first matrix");
PrintArray(matrixA);
Console.WriteLine("The second matrix");
PrintArray(matrixB);
ProductOfMatrices(matrixA, matrixB);