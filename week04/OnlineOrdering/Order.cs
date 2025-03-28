public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private float _shipping;

    public Order(Customer customer)
    {
        _customer = customer;
        if (_customer.IsInUSA())
        {
            _shipping = 5;
        }
        else
        {
            _shipping = 35;
        }
    }

    public void AddToOrder(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += _shipping;
        return totalCost;
    }

    public List<string> GetPackingLabel()
    {
        List<string> products = new List<string>();
        foreach (Product product in _products)
        {
            products.Add(product.GetNameId());
        }

        return products;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = _customer.GetShippingLabel();
        return shippingLabel;
    }

}