// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Straight lines match!");
    else if (k1 == k2)
        Console.WriteLine("Straight lines are parallel!");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y=k1*x+b1;
        Console.WriteLine("Intersection point: (" + x + "; " +y + ")");
    }
}
Console.WriteLine("Enter a value b1: ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value k1: ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value b2: ");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a value k2: ");
double k2=Convert.ToDouble(Console.ReadLine());
IntersectionPoint(b1,k1,b2,k2);