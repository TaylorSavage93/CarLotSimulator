using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Done Create a seperate class file called Car
            //Done shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //Done methods should take one string parameter: the respective noise property


            //Done Now that the Car class is created we can instanciate 3 new cars
            var car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Bronco";
            car1.Year = 1973;
            car1.EngineNoise = "vroom";
            car1.HonkNoise = "Beep";
            car1.IsDriveable = true;

            var car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Silverado";
            car2.Year = 2020;
            car2.EngineNoise = "vrooooom";
            car2.HonkNoise = "Beep";
            car2.IsDriveable = true;

            var car3 = new Car();
            car3.Make = "Ford";
            car3.Model = "Mustang";
            car3.Year = 1969;
            car3.EngineNoise = "none";
            car3.HonkNoise = "Beep";
            car3.IsDriveable = false;

            car1.MakeEngineNoise(car1.EngineNoise);
            car2.MakeEngineNoise(car1.EngineNoise);
            car3.MakeEngineNoise(car1.EngineNoise);

            Console.WriteLine($"My favorite car is the {car1.Make} {car1.Model} {car1.Year} its engine goes {car1.EngineNoise} and its horn goes {car1.HonkNoise}.");
            Console.WriteLine($"My friend has a {car2.Make} {car2.Model} its a fairly new car since the year is {car2.Year} the engine goes {car2.EngineNoise} and the horn goes {car2.HonkNoise}.");
            Console.WriteLine($"My uncle owns a {car3.Year} {car3.Make} {car3.Model} its does not run so so the engine sound is {car3.EngineNoise} however the horn works it goes {car3.HonkNoise}.");

            //Set the properties for each of the cars
            //Call each of the methods for each car

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
