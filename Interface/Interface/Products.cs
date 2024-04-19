using System;
using System.Xml.Linq;
/*A concrete class named Products that inherits from the Inventory class and implements the IPriceable
interface. The Products class should have the following members:
• Field: Price of type double.
• Constructor: Accepting parameters for name, quantity, and price.
• Implementation of the GetPrice() method to return the price of the product.
• Implementation of the Name and Quantity properties inherited from the Inventory class.
• Implementation of the Display() method to print the name, quantity, and price of the product.*/

class Products : Inventory, IPriceable {
    public double Price;

    public Products(string name, int quantity, double price) {
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    public double getPrice() { 
        return Price;
    }

    public override string Name { get; }
    public override int Quantity { get; set; }

    public override void Display() {
        Console.WriteLine("The name of a product: " + Name + ", Quantiry: " + Quantity + ", and Price R" + Price);
    }
}