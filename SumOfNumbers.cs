using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number.");
        string num = Console.ReadLine();
        int length;
        while (int.TryParse(num, out length) == false)
        {
            Console.WriteLine("Invalid Input! Please enter an integer number like this - 1....4,etc.");
            num = Console.ReadLine();
        }
        double[] NumArray = new double[length];
        string checkNum;
        double element;
        for (int i = 0; i < NumArray.Length; i++)
        {
            Console.WriteLine("Please enter number {0}", i + 1);
            checkNum = Console.ReadLine();
            while (double.TryParse(checkNum, out element) == false)
            {
                Console.WriteLine("Invalid Input! Please enter a number.");
                checkNum = Console.ReadLine();

            }
            NumArray[i] = element;
        }
        double Sum = 0;
        for (int x = 0; x < NumArray.Length; x++)
        {
            Sum += NumArray[x];
        }
        Console.WriteLine("\nThe sum of the given numbers is: {0}", Sum);
    }
}

