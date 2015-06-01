using System;

class CirclePerimeterАndArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("{0,-10}|{1,10:F2}|", "Radius", radius);
        Console.WriteLine("{0,-10}|{1,10:F2}|", "Perimeter", 2 * Math.PI * radius);
        Console.WriteLine("{0,-10}|{1,10:F2}|", "Area", (radius *= radius) * Math.PI);
    }
}