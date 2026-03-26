// EXCEEDING REQUIREMENTS:
// I improved this program by ensuring that only words that are not already hidden
// are selected to be hidden. This makes the memorization process more efficient.
// I also structured the program using multiple classes (Word, Scripture, Reference)
// to demonstrate encapsulation and separation of responsibilities.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create multiple scriptures manually
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son"));

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"));

        scriptures.Add(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd I shall not want"));

        // Randomly select one
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Main loop
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

        Console.WriteLine("\nProgram finished.");
    }
}