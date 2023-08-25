using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var myCar = new Car();
            myCar.Year = 2022;
            myCar.Make = "Hyundai";
            myCar.Model = "Elantra";
            myCar.EngineNoise = "whir";
            myCar.HonkNoise = "beep";
            myCar.IsDriveable = true;
            lot.Cars.Add(myCar);
            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);
            Console.WriteLine($"There is currently { CarLot.numberOfCars} car on the lot.");

            var myTruck = new Car()
            {
                Year = 1996,
                Make = "Chevrolet",
                Model = "S-10",
                EngineNoise = "tick",
                HonkNoise = "Oomp",
                IsDriveable = true
            };
            lot.Cars.Add(myTruck);
            myTruck.MakeEngineNoise(myTruck.EngineNoise);
            myTruck.MakeHonkNoise(myTruck.HonkNoise);
            Console.WriteLine($"There are currently {CarLot.numberOfCars} cars on the lot.");

            var myOldCar = new Car(1997, "Ford", "Probe", "no", "Yes", false);
            lot.Cars.Add(myOldCar);
            myOldCar.MakeEngineNoise(myOldCar.EngineNoise);
            myOldCar.MakeHonkNoise(myOldCar.HonkNoise);
            Console.WriteLine($"There are currently {CarLot.numberOfCars} cars on the lot.");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("The following vehicles are currently on the lot:");
            Console.WriteLine("------------------------------------------------");
            foreach (var car in lot.Cars) 
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

        }

    }
}
