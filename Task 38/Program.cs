// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] FillArray(int number)
{
    int[] mas = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write("Enter the " + i + " element: ");
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mas;
}
int FindMax(int[] array)
{
    int max =array[0];
     foreach (var item in array)
    {
        if (item>max)
        max=item;
    }
    return max;
}
int FindMin(int[] array)
{
    int min =array[0];
     foreach (var item in array)
    {
        if (item<min)
        min=item;
    }
    return min;
}
int difference(int max, int min)
{
return max-min;
}
Console.WriteLine("Enter the length of the array");
int length=Convert.ToInt32(Console.ReadLine());
int[] array=FillArray(length);
Console.WriteLine("The difference between minimum and maximum: "+difference(FindMax(array),FindMin(array)));