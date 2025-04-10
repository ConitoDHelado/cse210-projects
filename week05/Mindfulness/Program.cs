using System;
using System.Formats.Asn1;
/// <summary>
/// For showing creativity I made sure no repeated questions or prompts are shown to the user during any given session. The Constructor uses setters to populate the lists. The program randomly chooses a question or prompt from a list. Then they remove it. If the list empties (AKA list.Count == 0) then the setter is used again to repopulate them. The Listing activity uses this for its prompts and the Reflecting Activity uses it for both the prompts and questions.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string answer = "0";

        while (answer != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();
            Console.Clear();

            if (answer == "1")
            {
                BreathingActivity a = new BreathingActivity();
                a.Run();
            }

            else if (answer == "2")
            {
                ReflectingActivity a = new ReflectingActivity();
                a.Run();
            }

            else if (answer == "3")
            {
                ListingActivity a = new ListingActivity();
                a.Run();
            }

            else if (answer == "4")
            {
                Console.WriteLine("See you soon");
                Thread.Sleep(3000);
            }

            else
            {
                Console.WriteLine("Please enter a choice from the menu");
                Thread.Sleep(3000);
            }
        }

        Console.Clear();

    }
}