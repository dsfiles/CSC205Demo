using System;

namespace CSC205Quiz02
{
    public class Program
    {
        static void Main(string[] args)
        {
            // car1 does not have any information.
            var car1 = new Vehicle();
            var car2 = new Vehicle("1FM0122021", "Ford", "Mercury", 0);
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
        private string vin, make, model;
        private int mileage;
        public Vehicle() // constructor #1
        {
            vin = "N/A"; make = "N/A"; model = "N/A";
            mileage = 0;
        }
        public Vehicle(string vin, string make, string model, int mileage)
        {  // constructor #2 with parameters
            this.vin = vin;
            this.make = make;
            this.model = model;
            this.mileage = mileage;
        }
        public void Drive(int mileage)
        {
            this.mileage += mileage;
        }
        public void Display()
        {
            Console.WriteLine($"vin: {vin}, make: {make}, model: {model}, mileage: {mileage}");
        }
    }
}

