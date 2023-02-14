// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
int row = new Random().Next(5,7);

int[,] array = new int[row, row];
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
FillArray(array);
PrintArray(array);
Console.WriteLine();
if (array.GetLength(0) != array.GetLength(1) ) 
{
    Console.WriteLine("Не возможное условие выполнения программы");
    return;
} 
ModifyArray(array);

void ModifyArray(int [,] arr)
{ 
    for (int row = 0; row < arr.GetLength(0); row++)
    {
      for (int col = row+1; col < arr.GetLength(1); col++)
      {
        int temp = arr[row,col];
        arr[row,col] = arr[col,row];
        arr[col,row] = temp;
      }
    }
}