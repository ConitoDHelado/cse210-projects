public class Product
{
    private string _name;
    private string _id;
    private float _price;
    private float _quantity;

    public Product

    public float TotalCost()
    {
        float total = _quantity * _price;
        return total;
    }
}