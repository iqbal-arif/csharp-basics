using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System;
namespace Ex4ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Excercise - 4
            //Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.Write a program that asks the user to enter the speed limit.Once set, the program asks for the speed of a car.If the user enters a value less than the speed limit, program should display Ok on the console.If the value is above the speed limit, the program should calculate the number of demerit points.For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.If the number of demerit points is above 12, the program should display License Suspended.
            
            int demeritDelta = 0;
            bool demerit=true;
            do
            {
                
            Console.WriteLine("Speed Limit Detactor!\n");

            Console.WriteLine("Enter the Speed Limit");

            int speedLimit = int.Parse(Console.ReadLine());

                do
                {
                Console.WriteLine("Enter your Car Speed");

                int carSpeedLimit = int.Parse(Console.ReadLine());

                int speedDifference;


                Console.WriteLine($"\nDemerit Delta Top : {demeritDelta}");


                if (carSpeedLimit > speedLimit)
                {
                    speedDifference = carSpeedLimit - speedLimit;
               
                if (speedDifference <= 12)
                {

                    demeritDelta ++;


                    Console.WriteLine($"\nDemerit Delta is :{demeritDelta}");
                }


                if (demeritDelta >= 12)
                {
                        Console.WriteLine("Your License has been Suspended");
                        demerit = false;
                }
                }
                    
                }
                while (   );



            }
            while (demerit);






        }
    }
}
