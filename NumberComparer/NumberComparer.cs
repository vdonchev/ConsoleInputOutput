using System;

class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        // Math.Max()
        Console.Write("Using Math.Max(): ");
        Console.WriteLine(Math.Max(a, b));

        // ternery
        Console.Write("Using ternery operator: ");
        Console.WriteLine("{0}", a > b ? a : b);
    }
}