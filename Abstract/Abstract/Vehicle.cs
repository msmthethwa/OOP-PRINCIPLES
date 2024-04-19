using System;
/*Define an abstract class Vehicle with the following properties and methods:
• A private integer field numWheels to store the number of wheels.
• An abstract method Display() that should be implemented by subclasses.
• A public getter method GetNumWheels() to retrieve the number of wheels.*/

abstract class Vehicle {
    public int numWheels;

    public abstract void Display();

    public int getNumWheels()
    {
        return numWheels;
    }
}