// EXCEEDING REQUIREMENTS:
// I improved this program by ensuring that only words that are not already hidden
// are selected to be hidden. This makes the memorization process more efficient.
// I also structured the program using multiple classes (Word, Scripture, Reference)
// to demonstrate encapsulation and separation of responsibilities.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(reference,
            "For God so loved the world that he gave his only begotten Son");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit':");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}