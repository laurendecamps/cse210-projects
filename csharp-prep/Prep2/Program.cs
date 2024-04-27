using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string answer = console.readline();
        int percent = int.parse(answer);

        string letter = "";

        if (percent >= 90)
        { letter = "A"; }
        else if (percent >= 80)
        { letter = "B"; }
        else if (percent >= 70)
        { letter = "C"; }
        else if (percent >= 60)
        { letter = "D"; }
        else { letter = "F"; }

        console.writeline($"Your grade is: {letter}");

        if (percent >= 70)
        { console.writeline("You passed!");}
        else { console.writeline("Better luck next time!";)}
    }
}
