using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Car
    {

        public Car() { }
        public Car(string brand, string model, int year, string fueltype, string color)
        {

            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Fueltype = fueltype;
            this.Color = color;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Fueltype { get; set; }
        public string Color { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Brand {Brand}, Model {Model}, Year {Year}, Fueltype {Fueltype}, Color {Color} ");
        }
}}
