using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you showed courage.",
        "Think of a time you overcame something difficult."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "How can you use this again?"
    };

    private Random _rand = new Random();

    public ReflectingActivity()
        : base("Reflecting", "Reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\n" + GetRandomPrompt());
        Console.WriteLine("\nThink about it...");
        ShowSpinner(5);

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine("\n" + GetRandomQuestion());
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }
}