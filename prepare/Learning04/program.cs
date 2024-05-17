using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Lauren DeCamps", "Fractions", "7.3", "8-19");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Ike DeCamps", "Addition");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Abby Carlson", "Film History", "Casablanca");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
