// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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
Console.WriteLine("----------------------------------");

void SumString(int [,] matr)
{int sum=0;
    for (int i = 0; i<matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1); j++)
        {
        sum+=matr[i,j];
        }
        Console.WriteLine("Summa "+i+" string ="+sum);
sum=0;
    }
}
SumString(matrix);