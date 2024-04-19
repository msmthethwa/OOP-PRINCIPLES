using System;
/*Your code should also include a Main method to demonstrate the usage of the Products class by creating an
instance of it and displaying its properties.
*/

class TestDriver { 
    static void Main()
    {
        Products product = new Products("Lenovo Legion Pro 7", 10, 78499);

        Console.WriteLine(product.Name);
        Console.WriteLine(product.getPrice());

        Console.WriteLine();
        product.Display();

        Console.Read();
    }
}