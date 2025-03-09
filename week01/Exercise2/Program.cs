using System;

class Program
{
    static void Main(string[] args)
    {
        //Get user's grade
        Console.Write("Please, enter your grade percentage (0 - 100): ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        char letter;

        if (grade >= 90)
        {
            letter = 'A';
        }

        else if (grade >= 80)
        {
            letter = 'B';
        }

        else if (grade >= 70)
        {
            letter = 'C';
        }

        else if (grade >= 60)
        {
            letter = 'D';
        }

        else
        {
            letter = 'F';
        }

        Console.WriteLine("Your grade is " + letter);

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed.");
        }

        else
        {
            Console.WriteLine("Sorry, you have failed the class.");
        }
    }
}