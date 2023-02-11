// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь
// содержит информацию о том, сколько раз встречается элемент входных данных.
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j], 3}");
        }
        Console.WriteLine();
    }
}
int[,] GenerateArray(int n, int m){
    int[,] arr = new int[n, m];
    for(int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(-10, 10);
        }
    }
    return arr;
}
int[] ArrayToString(int[,] arr){
    int[] newArray = new int[arr.GetLength(0)*arr.GetLength(1)];
    int i = 0;
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                newArray[i] = arr[row, col];
                i++;
            }
        }
        return newArray.Distinct().ToArray();
        
   }


void FindQuantityOfEachElementVal(int[,] arr, int[] uniqueArray){
    int count;
    for (int i = 0; i < uniqueArray.Length; i++)
    {
        count = 0;
        int num = uniqueArray[i];
        Console.Write($"Quantity of {num} -> ");
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if(num == arr[row, col]){
                    count++;
                }
            }
            
        }
        Console.WriteLine(count);
        
    }
    
}


int n = new Random().Next(3, 4);
int m = new Random().Next(3, 4);
int[,] array = GenerateArray(n, m);
PrintArray(array);
Console.WriteLine();
int[] uniqueArray = ArrayToString(array);
FindQuantityOfEachElementVal(array, uniqueArray);
