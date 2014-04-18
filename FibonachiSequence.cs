using System;

class FibonachiSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the Fibonachi sequence you want to see");
        string str = Console.ReadLine();
        ulong n;
        bool check = ulong.TryParse(str, out n);
        if (check == false)
        {
            Console.WriteLine("Invalid Number!\nPlease enter only integer numbers!");
        }

        ulong a = 0;
        ulong b = 1;

        for (ulong i = 0; i <= n; i++)
        {
            ulong fibOne = a;
            a = b;
            b = fibOne + a;
            Console.WriteLine("The Member {0} is {1}", i, a);
        }
    }
}

