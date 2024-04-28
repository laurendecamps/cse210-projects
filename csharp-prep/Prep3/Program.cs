using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int magicnumber = randomgenerator.next(1,101);

        int guess = -1;

        while (guess != magicnumber)
    {

        Console.WriteLine("What is your guess?");
        guess = int.parse(console.readline());

        if (magicnumber > guess)
        { console.writeline("Higher");
        }
        else if (magicnumber < guess)
        { console.writeline("Lower");
        }
        else
        { console.writeline("You guessed it!");
        }
    }
    }
}
