﻿using System;

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
            Car carone = new Car();
            Console.WriteLine(CarLot.numberOfCars);
            carone.Make = "Toyota";
            carone.Model = "Corolla";
            carone.Year = 2016;
            carone.IsDriveable = true;
            carone.EngineNoise = "vroom vroom";
            carone.HonkNoise = "beep beep";
            carone.MakeHonkNoise(carone.HonkNoise);
            carone.MakeEngineNoise(carone.EngineNoise);


            var cartwo = new Car()

            {
            Make = "Honda",
            Model = "CRV",
            Year = 2012,
            IsDriveable = true,
            EngineNoise = "vrooooom",
            HonkNoise = "beeeeeep",
            };
            Console.WriteLine(CarLot.numberOfCars);
            cartwo.MakeEngineNoise(cartwo.EngineNoise);
            cartwo.MakeHonkNoise(cartwo.HonkNoise);

            var carthree = new Car("Ford", "Focus", 2020, true, "vrooooom vroooom", "beeeeeep beeeeep");
            carthree.MakeEngineNoise(carthree.EngineNoise);
            carthree.MakeHonkNoise(carthree.HonkNoise);

            Console.WriteLine($"These are the cars available {carone.Make} {carone.Model}, {cartwo.Make} {cartwo.Model}, {carthree.Make} {carthree.Model}");
            Console.WriteLine(CarLot.numberOfCars);


            //Now that the Car class is created we can instanciate 3 new cars
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
