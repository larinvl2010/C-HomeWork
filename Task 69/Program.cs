Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int PowNum(int a, int b)
{
    if (b == 1) return a;
    return a * PowNum(a, b - 1);
}

Console.WriteLine(PowNum(A, B));
