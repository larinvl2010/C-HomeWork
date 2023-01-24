// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
if (number<1 || number>7)
{
    Console.WriteLine("Number is incorrect");
}
else if (number>0 && number < 6)
{
    Console.WriteLine("Working day");
}
else
{
    Console.WriteLine("Weekend");
}

