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
            return;
        }

        string letter;

        if ( x >= 90)
        {
           letter="A";
        }

        else if ( x >= 80)
        {
            letter="B";
        }

        else if ( x >= 70)
        {
            letter="C";
        }

        else if ( x >= 60)
        {
            letter="D";
        }

        else
        {
            letter="F";
        }

        int lastDigit = x % 10;
        string sign;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";    
        }
        else if (letter == "A" && x >= 93)
        {
            sign = "";     
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Keep working hard, and you'll do better next time!");
        }
    }
}