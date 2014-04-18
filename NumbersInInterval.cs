using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.WriteLine("Please enter a Number.");
        string FirstNumber = Console.ReadLine();
        int first;
        while (int.TryParse(FirstNumber, out first) == false)
        {
            Console.WriteLine("Invalid Input! Please enter an integer number like this - 1,2,3....etc.");
            FirstNumber = Console.ReadLine();
        }
        Console.WriteLine("Please enter a Number.");
        string SecondNumber = Console.ReadLine();
        int second;
        while (int.TryParse(SecondNumber, out second) == false)
        {
            Console.WriteLine("Invalid Input! Please enter an integer number like this - 1,2,3....etc.");
            SecondNumber = Console.ReadLine();
        }
        int check = 0;
        
        Console.WriteLine("The numbers after divide by 5 have a reminder 0 are: ");
        for (int i = first; i <= second; i++)
        {
            if (i % 5 == 0)
            {
                check = i;
                Console.Write("{0}, ",check);

            }
            if (i == second)
            {
                Console.Write(".");
            }
       
        }
        Console.WriteLine();
       
    }
}

