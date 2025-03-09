using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        float sum = 0;
        float avg;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            sum += number;

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        foreach (int integer in numbers)
        {
            if (integer > largest)
            {
                largest = integer;
            }
        }

        avg = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        

    }   

}