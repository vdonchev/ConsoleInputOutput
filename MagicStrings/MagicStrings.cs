using System;
using System.Collections.Generic;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        bool found = false;
        List<string> results = new List<string>();

        for (int i = 1111; i <= 5555; i++)
        {
            int sum1 = Calc(i);
            string seq1 = Convert.ToString(i);

            if (Check(seq1))
            {
                for (int j = 1111; j <= 5555; j++)
                {
                    int sum2 = Calc(j);
                    string seq2 = Convert.ToString(j);

                    if (Check(seq2))
                    {
                        if (Math.Abs(sum1 - sum2) == diff)
                        {
                            seq1 = seq1.Replace('1', 'k').Replace('3', 's').Replace('4', 'n').Replace('5', 'p');
                            seq2 = seq2 = seq2.Replace('1', 'k').Replace('3', 's').Replace('4', 'n').Replace('5', 'p');
                            results.Add(seq1 + seq2);
                            found = true;
                        }
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
        else
        {
            string[] finalOutput = results.ToArray();
            Array.Sort(finalOutput);

            foreach (var item in finalOutput)
            {
                Console.WriteLine(item);
            }
        }
    }

    private static int Calc(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            int remainder;
            n = Math.DivRem(n, 10, out remainder);
            sum += remainder;
        }
        return sum;
    }

    private static bool Check(string b)
    {
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] == '2' || b[i] == '0' || b[i] > '5')
            {
                return false;
            }
        }
        return true;
    }
}