using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace Ex9_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display the Maximum Number!");

            //Excercise - 10:
            //Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter serires of numbers separated by comma");

           
            // Taking the userInput

            string userInput = Console.ReadLine();

            var userStrings = userInput.Split(',');

            var numberList = new List<int>();

            foreach (var userString in userStrings)
            {
                Console.WriteLine(userString);

                var userNumber = Int32.Parse(userString);

                for (int i = 0; i < numberList.Count; i++)
                {

                    if (userNumber >= 0)
                    {
                        numberList.Add(userNumber);
                        continue;
                    }

                
                }


                

            }

            
        }
    }
}
