using System;

class Program
{
    static void Main(string[] args)
    {
        //Get user's grade
        Console.Write("Please, enter your grade percentage (0 - 100): ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        char gradeLetter;

        if (grade >= 90)
        {
            gradeLetter = 'A';
        }

        else if (grade >= 80)
        {
            gradeLetter = 'B';
        }

        else if (grade >= 70)
        {
            gradeLetter = 'C';
        }

        else if (grade >= 60)
        {
            gradeLetter = 'D';
        }

        else
        {
            gradeLetter = 'F';
        }

        Console.WriteLine("Your grade is " + gradeLetter);

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