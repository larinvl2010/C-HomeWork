// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i]=new Random().Next(100,1000);
    }
    return array;
}
int EvenNumbers(int[] array)
{
    int count=0;
    foreach (int item in array)
    {
        if(item%2==0)
        count++;
    }
    return count;
}
Console.WriteLine("Enter the length of the array");
int length=Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
Console.WriteLine("the number of even elements in the array [" + string.Join(" ",array)+"] : "+EvenNumbers(array));