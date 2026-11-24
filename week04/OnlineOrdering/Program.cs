using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Kimberly Alejos", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "NB100", 3.50, 4));
        order1.AddProduct(new Product("Pen Set", "PN200", 6.25, 2));

        Address address2 = new Address("Av. Arequipa 456", "Lima", "Lima", "Peru");
        Customer customer2 = new Customer("Carlos Rojas", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "BP300", 25.00, 1));
        order2.AddProduct(new Product("Water Bottle", "WB400", 12.50, 2));
        order2.AddProduct(new Product("Headphones", "HP500", 40.00, 1));

        Order[] orders = { order1, order2 };

        int number = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"===== Order {number} =====");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}");
            Console.WriteLine();
            number++;
        }
    }
}
