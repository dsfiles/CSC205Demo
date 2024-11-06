using System;
public class Vehicle // base class
{
    public string model;
    public int year;
    public Vehicle(string model, int year)
    {
        this.model = model;
        this.year = year;
    }
    public void DisplayModelYear()
    {
        Console.WriteLine($"model: {model}, year: {year}");
    }
}
public class Car : Vehicle
{
    private int seating_capacity;
    public Car(string model, int year, int capacity) : base(model, year)
    {
        seating_capacity = capacity;
    }
    public void DisplayInfo()
    {
        DisplayModelYear();
        Console.WriteLine($"seating capacity: {seating_capacity}");
    }
}
public class Truck : Vehicle {
    private int load_capacity;
    public Truck(string model, int year, int capacity) : base(model, year)
    {
        load_capacity = capacity;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"model: {model}, year: {year}, load capacity: {load_capacity} tons");
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Honda Accord", 2019, 5);
        var truck = new Truck("kenworth W990", 2020, 50);
        car.DisplayInfo();
        truck.DisplayInfo();
    }
}

