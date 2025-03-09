using System;
using System.Formats.Asn1;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);

            int guess;
            int numberGuesses = 0;
            do
            {
                numberGuesses++;
                Console.Write("What is your guess?: ");

                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != magicNumber);



            Console.WriteLine($"You guessed it! It took you {numberGuesses} guesses");
            Console.Write("Do you want to play again?(Y/N): ");
            answer = Console.ReadLine().ToLower();
        } while (answer == "y" || answer == "yes");
    }
}