using System;

class TestDriver {
    static void Main() {
        Car car = new Car();

        Console.WriteLine(car.numWheels);

        Console.WriteLine();

        car.go();

        Bike bike = new Bike();

        Console.WriteLine("The number of bike wheels: " + bike.numWheels);

        Console.Read();
    }
}