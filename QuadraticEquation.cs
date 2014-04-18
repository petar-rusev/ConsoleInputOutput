using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the \"a\"qoefficient");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the \"b\"qoefficient");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the \"c\"qoefficient");
        double c = double.Parse(Console.ReadLine());

        double D = (b * b) - (4 * a * c);
        if (D < 0)
        {
            Console.WriteLine("There is no real solve of the equation!");
        }
        else if (D > 0)
        {
            double xOne = (-b + Math.Sqrt(D)) / (a * a);
            double xTwo = (-b - Math.Sqrt(D)) / (a * a);
            Console.WriteLine("The solves of the given equation is\nx1 = {0}\nx2 = {1} ", xOne, xTwo);
        }
        else
        {
            double onlyRoot = -b / (2 * a);
            Console.WriteLine("The given equation has only one real root x1 = {0}", onlyRoot);
        }
    }
}

