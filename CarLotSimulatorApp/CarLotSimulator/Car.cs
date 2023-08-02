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
        public Car(string make, string model, int year, bool isDriveable, string engineNoise, string honkNoise)
        {
            Make=make;
            Model=model;
            Year=year;
            IsDriveable=isDriveable;
            EngineNoise = engineNoise;
            HonkNoise =honkNoise;
            
        }   

        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise =engineNoise;
            Console.WriteLine($"the engine makes a {engineNoise} noise");

        }

        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"The horn makes a {honkNoise} noise ");


        }




    }
}
