using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage from 0 to 100? ");
        string userInput = Console.ReadLine();
        int x = int.Parse(userInput);

        if ( x < 0 || x > 100)
        {
            Console.WriteLine("This is not a grade percentage.");
        }

        else if ( x >= 90)
        {
            Console.WriteLine("Your grade is A.");
        }

        else if ( x >= 80)
        {
            Console.WriteLine("Your grade is B.");
        }

        else if ( x >= 70)
        {
            Console.WriteLine("Your grade is C.");
        }

        else if ( x >= 60)
        {
            Console.WriteLine("Your grade is D.");
        }

        else
        {
            Console.WriteLine("Your grade is F.");
        }
    }
}