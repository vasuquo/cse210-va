public class Product
{
    private int _productId;
    private string _productName;
    private float _price;
    private int _quantity;

    public Product(int productId, string productName, float price, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public float GetCost()
    {
        return _price * _quantity;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public string GetProductName()
    {
        return _productName;
    }

}