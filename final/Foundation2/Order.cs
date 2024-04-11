public class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;
    private float _totalOrderCost;
    private float _shippingCost;

    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _product = product;
        _totalOrderCost = 0;

        if (_customer.GetLocation())
        {
            _shippingCost = 5f;
        }
        else
        {
            _shippingCost = 35f;
        }
    }

    public float GetTotalOrderCost()
    {
        foreach (Product product in _product)
        {
            _totalOrderCost += product.GetCost();
        }
        return _totalOrderCost + _shippingCost;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing List");
        Console.WriteLine("============");
        foreach (Product product in _product)
        {
            Console.WriteLine($"{product.GetProductId()} {product.GetProductName()}");            
        }
        Console.WriteLine(" ");
        
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine("==============");
        Console.WriteLine($"{_customer.GetCustomerName()}\n{_customer.GetAddress()}");
        Console.WriteLine(" ");
    }

}