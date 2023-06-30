using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carLot = new CarLot();

            Car car1 = new Car();
            
            car1.Make = "Ford";
            car1.Model = "F250";
            car1.Year = "2012";
            car1.IsDriveable = "Yes";
            car1.EngineNoise = "Smooth";
            car1.HonkNoise = "Normal";
            
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            carLot.ListOfCars.Add(car1);

            Car car2 = new Car() 
            { 
                Make = "Ford",
                Model = "Escape",
                Year = "2010",
                IsDriveable = "Yes",
                EngineNoise = "Rough",
                HonkNoise = "Normal" 
            };
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            carLot.ListOfCars.Add(car2);

            Car car3 = new Car("Subaru", "Crosstrek", "2023", "Quiet", "Normal", "Yes");

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            carLot.ListOfCars.Add(car3);

            foreach (var item in carLot.ListOfCars)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");
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
