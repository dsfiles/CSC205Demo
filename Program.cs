using System;

namespace CSC205Quiz02
{
    public class Program
    {
        static void Main(string[] args)
        {
            // car1 does not have any information.
            var car1 = new Vehicle();
            var car2 = new Vehicle() { Vin = "1FM0122021", Make = "Ford", Model = "Mercury", Mileage = 0 };
            car2.Drive(100);
            Console.Write("Car #1: ");
            car1.Display();
            Console.Write("Car #2: ");
            car2.Display();
            car2.Drive(90);
            Console.Write("After driving car #2 90 miles\nCar #2: ");
            car2.Display();
        }
    }

    public class Vehicle
    {
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }

        public void Drive(int miles)
        {
            this.Mileage += miles;
        }
        public void Display()
        {
            Console.WriteLine($"Vin: {Vin}, make: {Make}, Model: {Model}, Mileage: {Mileage}");
        }
    }
}