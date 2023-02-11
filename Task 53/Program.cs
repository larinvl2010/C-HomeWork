// Задача 53: Задайте двумерный массив.  // Напишите программу, которая поменяет местами первую и последнюю строку массива.  
Console.WriteLine("Введите число элементов массива - значение М: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число элементов массива - значение N: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[,] arr = new int[m, n];  
for (int i = 0; i < arr.GetLength(0); i++) 
{     
    for (int j = 0; j < arr.GetLength(1); j++)     
    {         
        arr[i, j] = new Random().Next(-10, 11);     
    } 
}  

void PrintArr(int[,] arry) 
        {     
            for (int i = 0; i < arry.GetLength(0); i++)     
            {         
                for (int j = 0; j < arry.GetLength(1); j++)         
                {             
                    Console.Write($"{arry[i, j],3}");         
                }         
                    Console.WriteLine();     
            }
        }

void ChancheStringArr(int[,] arry) 
{     
    int[] temp = new int[arry.GetLength(1)];     
    for (int j = 0; j < arry.GetLength(1); j++)     
    {         
        temp[j] = arry[0, j];         
        arry[0, j] = arry[arry.GetLength(0)-1, j];         
        arry[arry.GetLength(0)-1, j] = temp[j];     
        } 
        }  
        PrintArr(arr); 
        ChancheStringArr(arr); 
        Console.WriteLine(); 
        PrintArr(arr);