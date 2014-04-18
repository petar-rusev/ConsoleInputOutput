using System;

class FiveNumbersSum
{
    static void Main()
    {
        int[] numbers = new int[5];
        bool successfulParse = true;
        for (int i = 0; i <= numbers.Length - 1; i++)
        {
            Console.WriteLine("Enter number - {0}", i+1);
            string str = Console.ReadLine();
            successfulParse = successfulParse && int.TryParse(str, out numbers[i]);

        }

        Console.WriteLine(successfulParse ? "The sum of the five numbers is" + ":" + " " + (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) : "Invalid number please enter only Integer numbers without\nfloating point!");

    }
}

