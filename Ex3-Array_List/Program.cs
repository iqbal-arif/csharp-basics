using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Xml;

namespace Ex3_Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Storing, Validating, and Sorting!\n");

            //3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            List<int> nubmerList = new List<int>();

            //bool loopExit = true;

                Console.WriteLine("Enter any five numbers here!\n");

                int firstNumber = int.Parse(Console.ReadLine());

                nubmerList.Add(firstNumber);


            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"\nEnter number {i+1} !\n");

                int nextNumber = int.Parse( Console.ReadLine());

                // Checking if entered number exists or not
                if (nubmerList.Contains(nextNumber))
                {
                    Console.WriteLine("This number is alreay stored in the list !\n\nPlease try again !!!\n");
                    i--; // Decrementing i to reapt the same prompt over and over until new number is entered.
                }
                else
                {
                    nubmerList.Add(nextNumber); //adding new number
                }
            }

            // Sorting Number
            nubmerList.Sort(); 

            Console.WriteLine("\nYou Entered following five numbers :\n");

            //Displaying the list
            foreach (int sortNumber in nubmerList) 
            { 
            Console.WriteLine(sortNumber);
            
            }

        }
    }
}
