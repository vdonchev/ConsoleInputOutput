using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int endNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= endNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}