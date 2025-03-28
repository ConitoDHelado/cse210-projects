using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Apple", "AP001", 1.87, 3);
        Product p2 = new Product("Milk", "MI002", 3.99, 1);
        Product p3 = new Product("Bread", "BR003", 2.00, 10);
        Product p4 = new Product("Water", "WA004", 5.99, 7);
        Product p5 = new Product("Juice", "JU005", 1.59, 2);
        Product p6 = new Product("Cereal", "CE006", 4.85, 4);

        Address a1 = new Address("6001 S Lakeshore Dr", "Tempe", "AZ", "USA");
        Address a2 = new Address("2700 Rio Grande Ln", "Santa Cruz", "Tenerife", "Spain");

        Customer c1 = new Customer("John Doe", a1);
        Customer c2 = new Customer("Jane Doe", a2);

        Order o1 = new Order(c1);
        o1.AddToOrder(p1);
        o1.AddToOrder(p2);
        o1.AddToOrder(p3);

        Order o2 = new Order(c2);
        o2.AddToOrder(p4);
        o2.AddToOrder(p5);
        o2.AddToOrder(p6);

        List<string> o1PackingLabel = o1.GetPackingLabel();
        string o1ShippingLabel = o1.GetShippingLabel();
        double o1Total = o1.GetTotalCost();

        List<string> o2PackingLabel = o2.GetPackingLabel();
        string o2ShippingLabel = o2.GetShippingLabel();
        double o2Total = o2.GetTotalCost();

        Console.WriteLine("==============");
        Console.WriteLine("Order #1");
        Console.WriteLine("Packing Label: ");

        foreach (string line in o1PackingLabel)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine();
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(o1ShippingLabel);
        Console.WriteLine();
        Console.WriteLine($"Total: ${o1Total:F2}");
        Console.WriteLine("==============");

        Console.WriteLine("==============");
        Console.WriteLine("Order #2");
        Console.WriteLine("Packing Label: ");

        foreach (string line in o2PackingLabel)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine();
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(o2ShippingLabel);
        Console.WriteLine();
        Console.WriteLine($"Total: ${o2Total:F2}");
        Console.WriteLine("==============");


        


    }
}