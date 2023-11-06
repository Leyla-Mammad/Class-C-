// See https://aka.ms/new-console-template for more information



using ConsoleApp12;
using System.Globalization;
class Program
{
    static void Main()
    {
        var Leyla = new Person("Leyla", "Mammadova", 27, true);

        Leyla.PrintInfo();

        var Chevrolet = new Car("Chevrolet", "Camaro", 2003, "Petrol", "white");

        Chevrolet.PrintInfo();


        Car1 car1 = new Car1("Sedan", "Toyota", 2022, 120, 5);
        car1.PrintInfo();
        car1.CheckSpeed(130); 


        Motorcycle motorcycle = new Motorcycle("Chopper", "Harley-Davidson", 2021, 100, true);
        motorcycle.PrintInfo();
        motorcycle.CheckSpeed(100);


        var Mammadova = new user("Leyla", "Mammad", "ruslan" , 47);
        Mammadova.PrintInfo();
        Mammadova.IsPasswordValid("Leylamammad");
    }
}

    class Person
{
    public Person() { }
    public Person(string name, string surname, byte age, bool IsAdult)
    {

        this.Name = name;
        this.SurName = surname;
        this.Age = age;
        IsAdult = age > 18;
    }
        public string Name { get; set; }
    public string SurName { get; set; }
    public byte Age { get; set; }
    public bool IsAdult { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Name {Name}, Surname {SurName}, Age {Age}, IsAdult {IsAdult} ");
    }
    } 
        
