using System;
using System.Formats.Asn1;

// Added a check to HideRandomWords to only select words that have not been hidden
// Added an atribute to the word class so it diffirinciates between alphanumerical and punctuation characters.
class Program
{
    const string scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

    static void Main(string[] args)
    {

        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, scriptureText);
        string text = scripture.GetDisplayText();

        Console.Clear();
        Console.WriteLine(text);
        Console.WriteLine();
        Console.Write("Press Enter to continue or type 'quit' to finish: ");
        string answer = Console.ReadLine();

        if (answer != "quit")
            do
            {
                Console.Clear();
                scripture.HideRandomWords(3);
                text = scripture.GetDisplayText();
                Console.WriteLine(text);
                Console.WriteLine();
                Console.Write("Press Enter to continue or type 'quit' to finish: ");
                answer = Console.ReadLine();

            } while (answer != "quit" && !scripture.IsComppletelyHidden());

        Console.Clear();
    }
}