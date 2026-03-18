// EXCEEDING REQUIREMENTS:
// I improved this program by ensuring that only words that are not already hidden
// are selected to be hidden. This makes the memorization process more efficient.
// I also structured the program using multiple classes (Word, Scripture, Reference)
// to demonstrate encapsulation and separation of responsibilities.

using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

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

    static List<Scripture> LoadScriptures(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);
            string text = parts[3];

            Reference reference = new Reference(book, chapter, verse);
            Scripture scripture = new Scripture(reference, text);

            scriptures.Add(scripture);
        }

        return scriptures;
    }
}