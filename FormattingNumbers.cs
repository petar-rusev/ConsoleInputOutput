using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number (a):");
        string NumOne = Console.ReadLine();
        int a;
        while (int.TryParse(NumOne, out a) == false)
        {
            Console.WriteLine("Invalid Input! PLease enter an integer number between 0 and 500.");
            NumOne = Console.ReadLine();
        }
        if (a < 0 & a > 500)
        {
            Console.WriteLine("Invalid Input! Please enter an integer number between 0 and 500.");
            NumOne = Console.ReadLine();
        }
        Console.WriteLine("Please enter a number (b):");
        string NumTwo = Console.ReadLine();
        double b;
        while (double.TryParse(NumTwo, out b)==false)
        {
            Console.WriteLine("Invalid Input!Please enter a floating point number like this 3.12431");
            NumTwo = Console.ReadLine();
        }
       
        Console.WriteLine("Please enter a number (c):");
        string NumThree = Console.ReadLine();
        double c;
        while (double.TryParse(NumThree, out c) == false)
        {
            Console.WriteLine("Invalid Input!Please enter a floating point number like this 3.12431");
            NumThree = Console.ReadLine();
        }
        double NumTwoSigns = Math.Round(b, 2);
        double NumThreeSigns = Math.Round(c, 3);
        string hex = (a.ToString("X"));
        string bin = Convert.ToString(a, 2).PadLeft(2, '0');
        string Two = Convert.ToString(NumTwoSigns);
        
        string Three = Convert.ToString(NumThreeSigns);

        Console.Write("|{0}|{1}", hex.PadRight(10), bin);
        Console.Write("|{0}|{1}|", Two.PadLeft(10), Three.PadRight(10));
    }
}

