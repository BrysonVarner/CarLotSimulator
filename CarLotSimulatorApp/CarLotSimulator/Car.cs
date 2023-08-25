using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public Car() 
        {
            CarLot.numberOfCars++;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable) 
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.numberOfCars++;
        }
        public void MakeEngineNoise(string EngineNoise)
        {
            if (EngineNoise == null)
            {
                Console.WriteLine($"No noise noted from {Year} {Make} {Model}.");
            }
            
            var lowercaseEngineNoise = EngineNoise.ToLower();
            
            if (lowercaseEngineNoise == "yes" || lowercaseEngineNoise == "y") 
            { 
                Console.WriteLine($"{Year} {Make} {Model} makes a unidentified noise"); 
            }
            else if (lowercaseEngineNoise == "no" || lowercaseEngineNoise == "n") 
            {
                Console.WriteLine($"No noise heard from engine of {Year} {Make} {Model}.");
            }
            else 
            {
                Console.WriteLine($"There is a noise described as {EngineNoise} from {Year} {Make} {Model} .");
            }
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            if (HonkNoise == null)
            {
                Console.WriteLine($"No honk test noted for {Year} {Make} {Model}.");
            }

            var lowerCaseHonk = HonkNoise.ToLower();

            if (lowerCaseHonk == "yes" || lowerCaseHonk == "y")
            {
                Console.WriteLine($"Horn is operational for {Year} {Make} {Model}.");
            }
            else if (lowerCaseHonk == "no" || lowerCaseHonk == "n")
            {
                Console.WriteLine($"Horn not functioning in {Year} {Make} {Model}.");
            }
            else
            {
                Console.WriteLine($"The horn function is described as {HonkNoise} for {Year} {Make} {Model}.");
            }
        }
    }
}
