using System;

class SumOf5Numbers
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        double sum = 0;
        for (int i = 0; i < inputs.Length; i++)
        {
            sum += double.Parse(inputs[i]);
        }
        Console.WriteLine(sum);
    }
}