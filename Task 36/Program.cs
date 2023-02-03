// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i]=new Random().Next(0,10);
    }
    return array;
}
int SumEvenNumbers(int[] array)
{
    int i=0;
    int sum=0;
    foreach (int item in array)
    {
        if(i%2==1)
        sum+=item;
        i++;
    }
    return sum;
}
Console.WriteLine("Enter the length of the array");
int length=Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
Console.WriteLine("The sum of the elements in the array in odd positions [" + string.Join(", ",array)+"] : "+SumEvenNumbers(array));