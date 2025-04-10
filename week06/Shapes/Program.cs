using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("red", 2);
        Rectangle r = new Rectangle("blue", 2, 4);
        Circle c = new Circle("yellow", 3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}