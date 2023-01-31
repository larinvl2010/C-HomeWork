// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Write("Введите число: ");
string numstr=(Console.ReadLine());
int Sum(string numstr)
{
int num = Convert.ToInt32(numstr);
int index = 0;
int sum = 0;
for (int i = 1; i <= numstr.Length; i++)
{
    index=num%10;
    num=num/10;
    sum = sum+index;
}
return sum;
}
Console.WriteLine($"Сумма чисел {numstr} равна {Sum(numstr)} ");