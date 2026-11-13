using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._promptText = generator.GetRandomPrompt();
                entry._date = DateTime.Now.ToShortDateString();

                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice != "5")
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}