using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;

namespace FleetSim
{
    class Program
    {
        static void LoadCars()
        {
            var theCars = new List<Car>
                {
                new Car()
                {
                    VIN = "12345",
                    Color = "white",
                    LastServicedMileage = 0,
                    Mileage = 0,
                    Model = "Mazda CX5",
                    ModelYear = 2016
                },
                new Car()
                {
                    VIN = "67890",
                    Color = "red",
                    LastServicedMileage = 0,
                    Mileage = 0,
                    Model = "Honda CRV",
                    ModelYear = 2014
                },
                new Car()
                {
                    VIN = "ABCDE",
                    Color = "blue",
                    LastServicedMileage = 0,
                    Mileage = 0,
                    Model = "Jeep Wrangler",
                    ModelYear = 2010
                },
                new Car()
                {
                    VIN = "ABCDE",
                    Color = "red",
                    LastServicedMileage = 0,
                    Mileage = 0,
                    Model = "Alpha Romeo Stelvio",
                    ModelYear = 2018
                },
                new Car()
                {
                    VIN = "ABCDE",
                    Color = "white",
                    LastServicedMileage = 0,
                    Mileage = 0,
                    Model = "Ford F150",
                    ModelYear = 2004
                },
            };
            foreach (Car theCar in theCars)
            {
                System.Console.WriteLine(theCar.Model + " " + theCar.ModelYear);
            }
                /*Console.Readkey();*/
        }
    
       
        static void Main(string[] args)
        {
            LoadCars();
        }
    }
}
