using System;

class WorkHours
{
    static void Main()
    {
        // inputs
        int requiredHours = int.Parse(Console.ReadLine());
        double daysAvailable = double.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine());

        double workingHours = (daysAvailable - (daysAvailable * 0.1)) * 12 * productivity / 100;
        if (workingHours < requiredHours)
        {
            Console.WriteLine("No");
            Console.WriteLine((int)workingHours - requiredHours);
        } 
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine((int)workingHours - requiredHours);
        }
    }
}