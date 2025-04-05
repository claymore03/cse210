using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer cust1 = new Customer("John Doe", addr1);

        Console.WriteLine("--- Customer 1 ---");
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("USA Socket Set", "Z453", 23.99, 1));
        order1.AddProduct(new Product("Brake Pads", "G8723", 43.77, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");

        Console.WriteLine(" ");
        Console.WriteLine("--- Customer 2 ---");
        Address addr2 = new Address("1150 N Winchester Ln", "Nuevo Ciudad", "Mexico City", "Mexico");
        Customer cust2 = new Customer("Jose Menendez", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("HP Laptop", "X324Z7", 1399.99, 3));
        order2.AddProduct(new Product("Bluetooth Speaker", "G271", 39.45, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");

        Console.WriteLine(" ");
        Console.WriteLine("--- Customer 3 ---");
        Address addr3 = new Address("300 Oxford St", "London", "England", "UK");
        Customer cust3 = new Customer("John Doe", addr3);

        Order order3 = new Order(cust3);
        order3.AddProduct(new Product("Baked Beans", "H3321", 3.99, 50));
        order3.AddProduct(new Product("Tea", "T5465", 1.49, 200));

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost():0.00}");
        
        // Product product1 = new Product();
        // Address address1 = new Address();

        // Product product2 = new Product();
        // Address address2 = new Address();

        // Product product3 = new Product();
        // Address address3 = new Address();

        // Console.WriteLine("--- Product Information ---");
        // product1.SetProductName("Orange Juice");
        // product1.SetProductID(123);
        // product1.SetProductPrice(6);
        // product1.SetProductQuantity(12);
        // product1.TotalProductPrice();
        // product1.DisplayProductInfo();
        // Console.WriteLine();
        // Console.WriteLine("--- Customer Address ---");
        // address1.SetStreetAddress("133 N Aurora Ln");
        // address1.SetCityName("Wahoo");
        // address1.SetStateName("Nebraska");
        // address1.SetCountryName("USA");
        // address1.DisplayCustomerAddress();
        // address1.CountryCheck();
        // Console.WriteLine();
        // Console.WriteLine("--- Product Information ---");
        // product2.SetProductName("Mac Book Pro 12");
        // product2.SetProductID(456);
        // product2.SetProductPrice(1399);
        // product2.SetProductQuantity(3);
        // product2.TotalProductPrice();
        // product2.DisplayProductInfo();
        // Console.WriteLine();
        // Console.WriteLine("--- Customer Address ---");
        // address2.SetStreetAddress("4550 Bigsbury Ave");
        // address2.SetCityName("London");
        // address2.SetStateName("England");
        // address2.SetCountryName("UK");
        // address2.DisplayCustomerAddress();
        // address2.CountryCheck();
        // Console.WriteLine();
        // Console.WriteLine("--- Product Information ---");
        // product3.SetProductName("Electric Scooter");
        // product3.SetProductID(789);
        // product3.SetProductPrice(400);
        // product3.SetProductQuantity(2);
        // product3.TotalProductPrice();
        // product3.DisplayProductInfo();
        // Console.WriteLine();
        // Console.WriteLine("--- Customer Address ---");
        // address3.SetStreetAddress("2423 W Apple St, Apt 101");
        // address3.SetCityName("Toronto");
        // address3.SetStateName("Quebec");
        // address3.SetCountryName("Canada");
        // address3.DisplayCustomerAddress();
        // address3.CountryCheck();
    }
}