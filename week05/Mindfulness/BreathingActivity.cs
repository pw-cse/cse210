using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "Relax by breathing slowly.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int time = 0;

        while (time < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(3);

            Console.Write("\nBreathe out... ");
            ShowCountdown(3);

            time += 6;
        }

        DisplayEndingMessage();
    }
}