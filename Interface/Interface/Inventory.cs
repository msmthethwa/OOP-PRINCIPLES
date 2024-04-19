using System;
/*An abstract class named Inventory with the following abstract members:
• Property: Name of type string.
• Property: Quantity of type int.
• Method: void Display().*/

abstract class Inventory { 
    public abstract string Name { get; }

    public abstract int Quantity { get; set; }

    public abstract void Display();
}