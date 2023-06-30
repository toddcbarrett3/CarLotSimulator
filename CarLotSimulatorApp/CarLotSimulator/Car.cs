using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
        }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }
            public string EngineNoise { get; set; }
            public string HonkNoise { get; set; }
            public string IsDriveable { get; set; }

            public void MakeEngineNoise(string engNoise)
            {
                Console.WriteLine($"The engine is running {engNoise}");
            }
            public void MakeHonkNoise(string honkNoise) 
            {
                Console.WriteLine($"The horn sound is {honkNoise}");
            }
        public Car(string make, string model, string year, string engineNoise, string honkNoise, string isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
               
    }
}
