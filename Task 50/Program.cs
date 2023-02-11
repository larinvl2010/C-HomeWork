// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет
// 1 1 -> 9
Console.WriteLine("Enter size of matrix");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int [,] matrix= new int[A,B];

void PrintArray(int [,] matr)
{
    for (int i = 0; i<matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int [,] matr)
{
    for (int i = 0; i<matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1); j++)
        {
            matr [i,j]=new Random().Next(1,10);
        }
    }
}

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Enter indexes of matrix");
int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());

void FindIndexArray(int [,] matr)
{
    if (X<A && Y<B)
    {
        Console.WriteLine("Number of Matrix is "+matr[X,Y]);
    }
    else
    {
        Console.WriteLine("Cannot find this index");
    }
}
FindIndexArray(matrix);