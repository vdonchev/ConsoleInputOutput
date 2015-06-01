using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double x1, x2;

        double d = (b * b) - 4 * a * c;

        if(d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            double sqrt = Math.Sqrt(d);
            x1 = (-b - sqrt) / (2 * a);
            x2 = (-b + sqrt) / (2 * a);
            if(x1 == x2)
            {
                Console.WriteLine("x1=x2={0}", x1);
            }
            else
            {
                Console.WriteLine("x1={0}; x2={1}", x1, x2);
            }
        }
    }
}