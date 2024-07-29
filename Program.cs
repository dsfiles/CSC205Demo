using System;
class Car
{
    private string vin, make, model;
    private int mileage;
    public Car(string vin, string make, string model, int mileage=0)
    {
        this.vin = vin;
        this.make = make;
        this.model = model;
        this.mileage = mileage;
    }

    public void Drive(int miles) => mileage += (miles > 0) ? miles : 0;

    public void Display() => Console.WriteLine($"VIN: {vin}\nMake: {make}\nModel: {model}\nMileage: {mileage}\n");
}

class Program
{
   static void Main()
    {
        var car1 = new Car("2HGCM82633A004353", "Kia", "Sorento", 30000);
        var car2 = new Car("3FTFW1EF1EKE89766", "Nissan", "Titan XD");
        car1.Drive(120);
        car2.Drive(180);

        car1.Display();
        car2.Display();
    }
}

