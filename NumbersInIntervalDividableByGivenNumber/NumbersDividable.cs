using System;

class NumbersDividable
{
    static void Main()
    {
        // inputs
        int start = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());

        int result = 0;
        for (int i = start; i <= stop; i++)
        {
            if(i % 5 == 0)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}