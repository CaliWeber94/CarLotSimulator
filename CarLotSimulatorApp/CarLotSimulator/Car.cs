using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public bool IsDriveable { get; set; }

        public string EngineNoise { get; set; } 

        public string HonkNoise { get; set; }   



        public Car() { }    
        public Car(string make, string model, int year, bool isDriveable, string EngineNoise, string HonkNoise)
        {
            Make=make;
            Model=model;
            Year=year;
            IsDriveable=isDriveable;
            EngineNoise = EngineNoise;
            HonkNoise = HonkNoise;
            
        }   

        public static void MakeEngineNoise(string engineNoise)
        {
            engineNoise =engineNoise;
            Console.WriteLine($"the engine makes a {engineNoise} noise");

        }

        public static void MakeHonkNoise(string honkNoise)
        {
            honkNoise = honkNoise;
            Console.WriteLine($"The horn makes a {honkNoise} noise ");


        }




    }
}
