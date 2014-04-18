using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers.");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int aa;
        int bb;
        while (int.TryParse(a, out aa) & int.TryParse(b, out bb) == false)
        {
            Console.WriteLine("One of the numbers is invalid input.Please enter two integer numbers.\nExample - 1 or 95");
        }
        
        int check = (aa > bb) ? aa : bb;
        Console.WriteLine("The bigger number from {0} and {1} is {2}",aa,bb,check);
    }
}

