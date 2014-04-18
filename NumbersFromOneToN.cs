using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter a number!");
        double a = double.Parse(Console.ReadLine());

        for (double i = 1; i <= a; i++)
        {
            Console.WriteLine("{0:#.##}\n", i);
        }
    }
}

