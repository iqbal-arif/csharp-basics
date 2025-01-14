using System.ComponentModel;
using System;

namespace Ex6_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Summation!\n");

            //Excercise - 6
            //Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

        
            // Number summation
            int summation = 0;

            string userInput;

            do
            {
                Console.Write("Please enter a number (or 'ok' to exit): \n");

                userInput = Console.ReadLine();

                // Number Entry and Summation Loop

                while (string.IsNullOrEmpty(userInput) || (userInput.ToLower() != "ok"))
                {
                    int enteredNum = Int32.Parse(userInput);

                    summation = summation + enteredNum;

                    Console.WriteLine($"Your Total number is: {summation}\n");

                    Console.WriteLine("Enter next number please\n");

                    userInput = Console.ReadLine();

                }

                // Check for Empty String
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Input cannot be empty. Please enter number of 'ok' to exit.");
                }
                // Check the string for not 'OK' and any other character, such as, 'eaes'
                else if (userInput.ToLower() != "ok" && !int.TryParse(userInput, out _))
                {

                    Console.WriteLine("Please enter a valid number or 'ok' to exit.");
                }

            } while (string.IsNullOrEmpty(userInput) || (userInput.ToLower() != "ok" && !int.TryParse(userInput, out _)));



        }
    }
}
