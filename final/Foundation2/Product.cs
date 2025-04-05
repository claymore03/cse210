class Product
{
    public string Name { get; }
    public string ProductId { get; }
    public double PricePerUnit { get; }
    public int Quantity { get; }

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}

// class Product
// {
//     private string _productName = "default";

//     private int _productID = 0;

//     private int _productPrice = 0;

//     private int _productQuantity = 0;

//     private int _productTotalPrice = 0;

//     public string GetProductName()
//     {
//         return _productName;
//     }

//     public void SetProductName(string productName)
//     {
//         _productName = productName;
//     }

//     public int GetProductID()
//     {
//         return _productID;
//     }

//     public void SetProductID(int productID)
//     {
//         _productID = productID;
//     }

//     public int GetProductPrice()
//     {
//         return _productPrice;
//     }

//     public void SetProductPrice(int productPrice)
//     {
//         _productPrice = productPrice;
//     }

//     public int GetProductQuantity()
//     {
//         return _productQuantity;
//     }

//     public void SetProductQuantity(int productQuantity)
//     {
//         _productQuantity = productQuantity;
//     }

//     public void TotalProductPrice()
//     {
//         _productTotalPrice = _productQuantity * _productPrice;
//     }

//     public void DisplayProductInfo()
//     {
//         Console.WriteLine($"Product Name: {_productName}");
//         Console.WriteLine($"Product ID#: {_productID}");
//         Console.WriteLine($"Price Per Unit: ${_productPrice}");
//         Console.WriteLine($"Quantity: {_productQuantity}");
//         Console.WriteLine($"Total Cost: ${_productTotalPrice}");
//     }
// }