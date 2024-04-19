using System;
/*Write a Main method to test the implemented functionality:
• Create an instance of the Bus class.
• Call the Display() method to set the number of wheels and display it.
• Call the GetNumWheels() method to retrieve the number of wheels and print it.*/

class TestDriver {
    static void Main() {
        Bus bus = new Bus();

        bus.Display();

        Console.WriteLine(bus.getNumWheels());

        Console.Read();
    }
}