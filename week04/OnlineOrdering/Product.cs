public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private double _quantity;

    public Product(string name, string id, double price, double quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetNameId()
    {
        string nameid = $"{_name}({_id})";
        return nameid;
    }

    public double GetTotalCost()
    {
        double total = _quantity * _price;
        return total;
    }
}