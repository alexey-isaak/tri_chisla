using System;
 
namespace tri_chisla
{
    class Program
    {
        static void Main()
        {
Console.Write("Ведите число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());
double max = 0;

if (a > b)
{
    if (a > c)
    {
        max = a;
    }
    else
    {
        max = c;
    }
}
else
{
    if (b > c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}

Console.Write("Максимальное число: " + max);
        }
        }
}
