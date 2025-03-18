using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.SetTop(3);
        f1.SetBottom(7);
        int num = f1.GetTop();
        int den = f1.GetBottom();
        Console.WriteLine($"the numerator is {num} and denominator is {den}");

        // Why doesn't this work??
        string fraction = f1.GetFractionString();
        double decimalValue = f1.GetDecimalValue();
        Console.WriteLine($"{fraction} = {decimalValue}");

        // Console.WriteLine(f1.GetFractionString());
        // Console.WriteLine(f1.GetDecimalValue());

    }
}