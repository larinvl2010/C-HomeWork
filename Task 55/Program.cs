// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
int row = new Random().Next(5,7);

int[,] array = new int[row, row];
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