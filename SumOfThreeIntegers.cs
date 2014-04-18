using System;

class SumOfThreeIntegers
{
    static void Main()
    {
        string a = Console.ReadLine();
        int firstnum;
        while (int.TryParse(a, out firstnum)==false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer number.");
            a = Console.ReadLine();
        }
        string b = Console.ReadLine();
        int secnum;
        while (int.TryParse(b, out secnum) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer number.");
            b = Console.ReadLine();
        }
        string c = Console.ReadLine();
        int thirdnum;
        while (int.TryParse(c, out thirdnum) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer number.");
            c = Console.ReadLine();
        }
        int d = firstnum+secnum+thirdnum;
        Console.WriteLine("{0}+{1}+{2} = {3}",firstnum,secnum,thirdnum,d);
    }
}

