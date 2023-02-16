// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Enter a number M:");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number N:");
int n =Convert.ToInt32(Console.ReadLine());


int AkkermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AkkermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AkkermannFunction(numberM - 1, AkkermannFunction(numberM, numberN - 1));
return AkkermannFunction(numberM, numberN);
}

Console.WriteLine("Akkerman function for numbers A("+m+" "+n+")= "+AckermannFunction(m, n));