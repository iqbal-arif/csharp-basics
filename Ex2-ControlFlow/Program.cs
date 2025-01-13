using System.ComponentModel;

namespace Ex2_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2- Control Flow
            //Write a program which takes two numbers from the console and displays the maximum of the two

            string userInput;

           
                Console.Write("Please enter the First Number: ");
                var firstNumber = Console.ReadLine();

           
                Console.WriteLine($"You Entered : {firstNumber}\n");

                Console.WriteLine("Please enter the Second number: ");
                var secondNumber = Console.ReadLine();

                Console.WriteLine($"You Entered : {secondNumber}\n");

                int firstNumberInt = Int32.Parse(firstNumber);

                int secondNumberInt = Int32.Parse(secondNumber);

                if (firstNumberInt > secondNumberInt)
                {
                    Console.WriteLine($"\nThe Maximum number is: {firstNumberInt}");

                }
                else
                {
                    Console.WriteLine($"\nThe Maximum number is: {secondNumberInt}");

                }
               
           

        }
    }
}
