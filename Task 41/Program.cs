// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Enter number of arrey");
int num = Convert.ToInt32(Console.ReadLine());
int [] arrey1 = new int[num];
int count=0;
for (int i = 0; i<num-1; i++)
{
    arrey1[i]=new Random().Next(-100, 100);
    if (arrey1[i]>0)
    count=count+1;
}
Console.WriteLine(String.Join(",",arrey1));
Console.WriteLine("Numbers more 0 =" +count);
