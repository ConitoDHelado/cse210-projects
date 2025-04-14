using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Running running = new Running("20 Sep 2024", 30, 6);
        Console.WriteLine(running.GetSummary());
        Cycling cycling = new Cycling("20 Sep 2024", 45, 8);
        Console.WriteLine(cycling.GetSummary());
        Swimming swimming = new Swimming("20 Sep 2024", 60, 120);
        Console.WriteLine(swimming.GetSummary());
    }
}