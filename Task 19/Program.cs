// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 10000;
int num2 = num / 1000;
num2 = num2 % 10;
int num4 = num / 10;
num4 = num4 % 10;
int num5 = num % 10;
if (num>9999 && num < 100000) 
{    if (num1 == num5 && num2 ==num4)
Console.WriteLine("Number is polindrom");
    else
Console.WriteLine("Number is not polindrom");
}
else
{
    Console.WriteLine("Uncorrect number");
}