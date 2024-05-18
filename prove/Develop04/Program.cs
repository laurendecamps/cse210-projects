using System;

class Program
using System.Threading;

// Base class for activities
public abstract class Activity
{
    protected int durationInSeconds;

    public Activity(int durationInSeconds)
    {
        this.durationInSeconds = durationInSeconds;
    }

    public abstract void Start();
}

// Breathing activity
public class BreathingActivity : Activity
{
    public BreathingActivity(int durationInSeconds) : base(durationInSeconds) { }

    public override void Start()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine($"Duration: {durationInSeconds} seconds");
        Console.WriteLine("Prepare to begin...");

        // Show breathing messages
        for (int i = 0; i < durationInSeconds; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Good job! You have completed the Breathing Activity.");
        Console.WriteLine($"Duration: {durationInSeconds} seconds");
    }
}

// Reflection activity
public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int durationInSeconds) : base(durationInSeconds) { }

    public override void Start()
    {
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine($"Duration: {durationInSeconds} seconds");
        Console.WriteLine("Prepare to begin...");

        Random rnd = new Random();
        string randomPrompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(randomPrompt);

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(2000); // Pause for reflection
        }

        Console.WriteLine("Good job! You have completed the Reflection Activity.");
        Console.WriteLine($"Duration: {durationInSeconds} seconds");
    }
}

// Listing activity
public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int durationInSeconds) : base(durationInSeconds) { }

    public override void Start()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine($"Duration: {durationInSeconds} seconds");
        Console.WriteLine("Prepare to begin...");

        Random rnd = new Random();
        string randomPrompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(randomPrompt);

        Console.WriteLine("Start listing...");

        // Countdown timer
        for (int i = durationInSeconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Good job! You have completed the Listing Activity.");
        Console.WriteLine($"Duration: {durationInSeconds} seconds");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (choice == 4)
                break;

            int duration;
            Console.Write("Enter duration in seconds: ");
            if (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.WriteLine("Invalid duration. Please enter a positive integer.");
                continue;
            }

            Activity activity = null;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity(duration);
                    break;
                case 2:
                    activity = new ReflectionActivity(duration);
                    break;
                case 3:
                    activity = new ListingActivity(duration);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid activity.");
                    break;
            }

            if (activity != null)
            {
                activity.Start();
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
