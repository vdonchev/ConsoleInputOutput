using System;

class NewHouse
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int inner = 1;
        int outter = length / 2;
        for (int i = 0; i <= length / 2; i++)
        {
            Console.WriteLine("{1}{0}{1}", new string('*', inner), new string('-', outter));
            inner += 2;
            outter--;
        }

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("{1}{0}{1}", new string('*', length - 2), "|");
        }
    }
}