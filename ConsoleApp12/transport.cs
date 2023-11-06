using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Microsoft.VisualBasic.FileIO;
using System.Drawing;

internal class Vehicle
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public int Year { get; set; }
    public int MaxSpeed { get; set; }

    public Vehicle(string model, string brand, int year, int maxSpeed)
    {
        Model = model;
        Brand = brand;
        Year = year;
        MaxSpeed = maxSpeed;
    }

    public void CheckSpeed(int speed)
    {
        if (speed > 110)
        {
            Console.WriteLine("You will die");
        }
        else
        {
            Console.WriteLine("Go On");
        }
    }
}

internal class Car1 : Vehicle
{
    public int NumSeats { get; set; }

    public Car1(string model, string brand, int year, int maxSpeed, int numSeats)
        : base(model, brand, year, maxSpeed)
    {
        NumSeats = numSeats;

        
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Brand {Brand}, Model {Model}, Year {Year}, MaxSpeed {MaxSpeed}, Numseats {NumSeats} ");
    }
}

internal class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string model, string brand, int year, int maxSpeed, bool hasSidecar)
        : base(model, brand, year, maxSpeed)
    {
        HasSidecar = hasSidecar;

       
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Brand {Brand}, Model {Model}, Year {Year}, MaxSpeed {MaxSpeed}, HasSidecar {HasSidecar} ");
    }
}
