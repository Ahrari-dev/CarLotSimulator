using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var hasibsCar = new Car();
            hasibsCar.Make = "Honda";
            hasibsCar.Model = "Civic";
            hasibsCar.Year = 2020;
            hasibsCar.EngineNoise = "vroom";
            hasibsCar.HonkNoise = "beep";
            hasibsCar.IsDrivable = true;

            lot.Cars.Add(hasibsCar);

            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "vrrrooom",
                HonkNoise = "brmmp",
                IsDrivable = false,
            };

            lot.Cars.Add(stevesCar);

            var brettsCar = new Car(2013, "Honda", "Civic", "vrrroom", "vruuuga", true);

            lot.Cars.Add(brettsCar);

            //Call methods
            hasibsCar.MakeEngineNoise();
            stevesCar.MakeEngineNoise();
            brettsCar.MakeEngineNoise();

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
