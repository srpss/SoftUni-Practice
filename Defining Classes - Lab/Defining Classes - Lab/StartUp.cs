using System;
using System.Collections.Generic;
using System.Linq;
namespace Defining_Classes___Lab
{
    class StartUp
    {
        public class Car
        {
            public Car()
            {
                Make = "VW";
                Model = "Golf";
                Year = 2025;
                FuelQuantity = 200;
                FuelConsumption = 10;
            }
            public Car(string make, string model, int year) 
                : this()
            {
                Make = make;
                Model = model;
                Year = year;
            }
            public Car(string make, string model , int year , double fuelQuantity , double fuelConsumption ) 
                :this( make,  model,  year)
            {
                FuelQuantity = fuelQuantity;
                FuelConsumption = fuelConsumption;
            }
            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engines, Tire[] tires)
                :this( make,  model,  year,  fuelQuantity,  fuelConsumption)
            {
                Engines = engines;
                Tires = tires;
            }
            private Engine engines { get; set; }
            private Tire [] tires { get; set; }
            private string make { get; set; }
            private string model { get; set; }
            private int year { get; set; }
            private double fuelQuantity { get; set; }
            public Engine Engines { get; set; }
            public Tire [] Tires { get; set; }
            public double fuelConsumption { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double FuelQuantity { get; set; }
            public double FuelConsumption { get; set; }
            public void Drive(double distance)
            {
                if (FuelQuantity - distance *(FuelConsumption/100) <= 0)
                {
                    Console.WriteLine("Not enough fuel to perform this trip!");
                }
                else
                {
                    FuelQuantity -= -distance * (FuelConsumption / 100);
                }
            }
            public string WhoAmI() => $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";

        }
        public class Engine
        {
            private int horsePower { get; set; }
            private double cubicCapacity { get; set; }
            public int HorsePower { get; set; }
            public double CubicCapacity { get; set; }
            public Engine( int horsePower, double cubicCapacity)
            {
                HorsePower = horsePower;
                CubicCapacity = cubicCapacity;
            }
        }
        public class Tire
        {
            private int year { get; set; }
            private double pressure { get; set; }
            public int Year { get; set; }
            public double Pressure { get; set; }
            public Tire (int year, double pressure)
            {
                Year = year;
                Pressure = pressure;
            }
        }
        static void Main(string[] args)
        {
            //https://softuni.bg/trainings/resources/officedocument/64232/defining-classes-lab-csharp-advanced-september-2021/3483
            //_1_Car();
            //_2_CarExtension();
            //_3_CarConstructors();
            //_4_CarEngineandTires();
            //_5_SpecialCars();
        }
        private static void _5_SpecialCars()
        {
            string tire = "";
            var tireList = new List<Tire[]>();
            while ((tire = Console.ReadLine()) != "No more tires")
            {
                string[] tireArray = tire.Split();
                Tire[] four = new Tire[4]
                {
                    new Tire(int.Parse(tireArray[0]), double.Parse(tireArray[1])),
                    new Tire(int.Parse(tireArray[2]), double.Parse(tireArray[3])),
                    new Tire(int.Parse(tireArray[4]), double.Parse(tireArray[5])),
                    new Tire(int.Parse(tireArray[6]), double.Parse(tireArray[7])),
                };
                tireList.Add(four);
            }
            string engine = "";
            var enginesList = new List<Engine>();
            while ((engine = Console.ReadLine()) != "Engines done")
            {
                string[] engineArray = engine.Split();
                Engine newEngine = new Engine(int.Parse(engineArray[0]), double.Parse(engineArray[1]));
                enginesList.Add(newEngine);
            }
            string car = "";
            var carList = new List<Car>();
            while ((car = Console.ReadLine())!= "Show special")
            {
                string[] carArray = car.Split();
                Car newCar = new Car(carArray[0], 
                    carArray[1], 
                    int.Parse(carArray[2]), 
                    double.Parse(carArray[3]), 
                    double.Parse(carArray[4]), 
                    enginesList[int.Parse(carArray[5])],
                    tireList[int.Parse(carArray[6])]);
                    carList.Add(newCar);
            }
            foreach (var theCar in carList)
            {
                if (theCar.Year >= 2017 
                    && theCar.Engines.HorsePower > 330 
                    && theCar.Tires.Select(n => n.Pressure).Sum() >= 9 
                    && theCar.Tires.Select(n => n.Pressure).Sum() <= 10)
                {
                    theCar.Drive(20);
                    Console.WriteLine($"Make: {theCar.Make}\nModel: {theCar.Model}\nYear: {theCar.Year}\nHorsePowers: {theCar.Engines.HorsePower}\nFuelQuantity: {theCar.FuelQuantity}");
                }                
            }
        }
        private static void _4_CarEngineandTires()
        {
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(3, 2.3),
            };
            var engine = new Engine(560, 6300);
            var car = new Car("Lambo", "Urus", 2100, 250, 9 ,engine, tires);
        }

        private static void _3_CarConstructors()
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantaty = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantaty, fuelConsumption);
        }

        private static void _2_CarExtension()
        {
            Car car = new Car();            
            car.Make ="VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());            
        }

        private static void _1_Car()
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
