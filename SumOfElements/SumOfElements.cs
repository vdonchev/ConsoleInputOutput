using System;

class SumOfElements
{
    static void Main()
    {
        // inputs
        string[] ints = Console.ReadLine().Split(' ');
        long diff = long.MaxValue;
        long subDiff = 0;
        long winner = 0;

        for (int i = 0; i < ints.Length; i++)
        {
            long currentNum = long.Parse(ints[i]);
            long sum = 0;
            for (int j = 0; j < ints.Length; j++)
            {
                long subNum = long.Parse(ints[j]);
                sum += subNum;
            }
            long currentDiff = sum - currentNum;
            if (currentDiff == currentNum)
            {
                Console.WriteLine("Yes, sum={0}", currentNum);
                winner = 1;
                break;
            }
            else
            {
                subDiff = Math.Abs(currentDiff - currentNum);
                if(subDiff < diff)
                {
                    diff = subDiff;
                }
            }
        }
        if(winner == 0) 
        {
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}