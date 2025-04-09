public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";

        // Prompts for the activiy.
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMesage();
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items");
        Console.WriteLine();
        DisplayEndingMessage();


    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses to the following prompt:");
        Console.WriteLine($" ---{prompt} ---");
    }

    public void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> answers = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            answers.Add(Console.ReadLine());
        }

        _count = answers.Count();
    }




}