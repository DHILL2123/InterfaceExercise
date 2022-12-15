using System;
using System.Collections;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        
        

        static void Main(string[] args)
        {


            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany





            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car1 = new Car()
            { allHaveWheels = "all cars have wheels", willBreakDown = "and are gauranteed to break down", logo = "Chevy"};

            Console.WriteLine("What kind of car do you have?");
            string userinput = Console.ReadLine();
            
            Console.WriteLine($"{userinput}, well {car1.allHaveWheels} {car1.willBreakDown}, especially if it's a {car1.logo}!");


            Truck truck1 = new Truck()
            { catchPhrase  = "Built Ford TOUGH", willBreakDown = "means high price tag and high repair bill", logo = "Check Engine Light"};
            Console.WriteLine($"{truck1.catchPhrase}, {truck1.willBreakDown}. The {truck1.logo} symbol should be the logo!");

            Suv suv1 = new Suv()
            { allNeedFuel = true, oneWindShieldAtLeast = 1, allHaveWheels = "bigger wheels cost more money" };
            Console.WriteLine($"{suv1.allNeedFuel}, yes SUV's take more fuel than cars usually. {suv1.oneWindShieldAtLeast} protective glass is required" +
                $"in most SUVs. The {suv1.allHaveWheels} in most places.");


        }

    }
}
