// EXTRA CREDIT:
// > Save other information in the journal entry. I added a weather category to the Entry
// > I used the propmts.txt file to store the different prompts that will be given to the user. At the star of the program
// the program is read and it populates the PromptGenerator _prompts list

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // List of propmts for the user.
        PropmtGenerator prompts = new PropmtGenerator();
        string[] lines = System.IO.File.ReadAllLines("prompts.txt");

        foreach (string line in lines)
        {
            prompts._prompts.Add(line);   
        }

        // Journal
        Journal myJournal = new Journal();

        int menuSelection = 0;
        // Menu loop
        while (menuSelection != 5)
        {
            Console.WriteLine("Please, select one of the following choices by typing a number");
            Console.WriteLine("1. Write New Entry ");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal from File");
            Console.WriteLine("4. Save Journal to File");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuSelection = int.Parse(Console.ReadLine());

            if (menuSelection == 1) // NEW ENTRY
            {
                // Create new entry object
                Entry myEntry = new Entry();

                // Get date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                myEntry._date = dateText;

                // Get weather
                Console.WriteLine("What was the weather like today?");
                Console.WriteLine("> ");
                myEntry._weather = Console.ReadLine();

                // Generate random prompt from list
                string rndpromt = prompts.GetRandomPrompt();
                myEntry._promptText = rndpromt;



                // Get user's entry
                Console.WriteLine(rndpromt);
                Console.Write("> ");
                myEntry._entryText = Console.ReadLine();

                // Add entry to journal
                myJournal.AddEntry(myEntry);
            }

            else if (menuSelection == 2) // DISPLAY JOURNAL
            {
                myJournal.DisplayAll();
            }

            else if (menuSelection == 3) // LOAD JOURNAL FROM FILE
            {
                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }

            else if (menuSelection == 4) // SAVE JOURNAL TO FILE
            {
                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
        }
    }    
}