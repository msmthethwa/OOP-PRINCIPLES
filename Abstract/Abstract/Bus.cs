using System;
/*Implement a concrete subclass Bus inheriting from Vehicle with the following additional properties and
methods:
• A private integer field seatNums to store the number of seats.
• A private getter method GetNumSeats() to retrieve the number of seats.
• Override the Display() method to set the number of wheels to 4 and display it.*/

class Bus : Vehicle {
    public int seatNums;

    public int getNumSeats() {
        return seatNums;
    }


    public override void Display() {
        numWheels = 4;
        Console.WriteLine("The number of wheels: " + numWheels);
    }
}