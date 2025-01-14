using System.ComponentModel;

namespace Ex5_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count Number divisible by 3\n");

            //Excercise - 5
            //    Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.


            bool exit = true;

            int numberCounter = 0;
            do
            {
                Console.WriteLine("Enter Number between one and hundered !");

                //var userInput = Console.ReadLine();


                int userInput = Int32.Parse(Console.ReadLine());

                // Program Exit
                if (userInput == 0) 
                {
                    exit = false;
                }

                //  Checking Number divisible by 3
                int remainder = userInput % 3;


                if (remainder == 0)
                {
                    numberCounter++;

                    Console.WriteLine($"\nTotal number divisible by 3 between 1 and 100 : {numberCounter}");
                    Console.WriteLine("You may exit by entering '0'\n");
                }
                
            }
            while (exit);
        }
    }
}
