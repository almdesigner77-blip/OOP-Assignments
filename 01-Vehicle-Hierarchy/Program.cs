using System;

class Vehicle
{
    public string Brand;
    public int Year;

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine("The vehicle has started.");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors;

    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }
}

class Bus : Vehicle
{
    public int Capacity;

    public Bus(string brand, int year, int capacity)
        : base(brand, year)
    {
        Capacity = capacity;
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(string brand, int year, bool hasSidecar)
        : base(brand, year)
    {
        HasSidecar = hasSidecar;
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", 2024, 4);
        Bus bus = new Bus("Mercedes", 2022, 50);
        Motorcycle motorcycle = new Motorcycle("Honda", 2023, false);

        Console.WriteLine("Car:");
        Console.WriteLine("Brand: " + car.Brand);
        Console.WriteLine("Year: " + car.Year);
        Console.WriteLine("Number of Doors: " + car.NumberOfDoors);
        car.Start();

        Console.WriteLine();

        Console.WriteLine("Bus:");
        Console.WriteLine("Brand: " + bus.Brand);
        Console.WriteLine("Year: " + bus.Year);
        Console.WriteLine("Capacity: " + bus.Capacity);
        bus.Start();

        Console.WriteLine();

        Console.WriteLine("Motorcycle:");
        Console.WriteLine("Brand: " + motorcycle.Brand);
        Console.WriteLine("Year: " + motorcycle.Year);
        Console.WriteLine("Has Sidecar: " + motorcycle.HasSidecar);
        motorcycle.Start();
    }
}
