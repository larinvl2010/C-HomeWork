// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter a number M:");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number N:");
int n =Convert.ToInt32(Console.ReadLine());


int SumNumbers(int i, int j)
{
   if (i>j)
    {
    int temp=j;
    j=i;
    i=temp;
    } 
    if (i==j) return i;
    else return i+SumNumbers(i+1,j);
}
Console.WriteLine("Summa beetween M and N = "+SumNumbers(m,n));