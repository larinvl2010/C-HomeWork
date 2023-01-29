// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Enter a number:");
string number = Console.ReadLine();
int length = number.Length;
 int number2 = Convert.ToInt32(number);
if (length < 3)
{
    Console.WriteLine("Number is uncorrect");
}
else
{
    while (length > 3)
    {
        number2 = number2/10;
        length--;
    }

  
}int result =number2%10;
     Console.WriteLine(result);