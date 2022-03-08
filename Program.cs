using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Passenger car example #1
                PassengerCar car1 = new PassengerCar(35, Car.FuelType.Petrol, 5, 20, 2);

                car1.ToggleRadio();
                car1.SetPreset(1, 115.00);
                car1.SetPreset(2, 130.15);
                car1.SetPreset(3, 145.25);
                car1.TuneRadio(2);

                // Invalid argument
                // car1.TuneRadio(5);

                Console.WriteLine(car1);
                Console.WriteLine();

                // Passenger car example #2
                PassengerCar car2 = new PassengerCar(50, Car.FuelType.Diesel, 5, 30);

                Console.WriteLine(car2);
                car2.ToggleRadio();
                Console.WriteLine(car2);

                car2.Passengers = 3;
                Console.WriteLine(car2);

                // Invalid argument
                // car2.Passengers = 6;

                Console.WriteLine();

                // Truck example #3
                Truck truck1 = new Truck(100, Car.FuelType.Diesel, 50);
                
                truck1.Refuel(Car.FuelType.Diesel, 25);
                Console.WriteLine(truck1);

                // Invalid argument
                // truck1.Refuel(Car.FuelType.Petrol, 25);
                // truck1.Refuel(Car.FuelType.Diesel, 50);

                truck1.Load = 50;
                Console.WriteLine(truck1);

                // Invalid argument
                // truck1.Load = 70;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
