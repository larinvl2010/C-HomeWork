// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
if (num > 100 && num < 999)
{
    num2=num/100*100;
    num = num- num2;
    num = num / 10;
    Console.WriteLine(num);
}   
else
{
    Console.WriteLine("number is not three digits");
}


