using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        float pi = 3.14149265359f;
        Console.WriteLine("Please enter the radius of the circle.");
        string rad = Console.ReadLine();
        float radius;
        while (float.TryParse(rad, out radius) == false)
        {
            Console.WriteLine("Invalid Input!Please enter a real number for the radius of the circle it\nFor example - 4.54");
        }
        float area = pi * radius * radius;
        float perimeter = (2 * pi) * radius;
        Console.WriteLine("The area of the circle is {0:N}\nThe perimeter of the circle is {1:N}",area,perimeter);

    }
}

