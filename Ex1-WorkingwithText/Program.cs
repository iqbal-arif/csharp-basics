using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace Ex1_WorkingwithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consecutive & Non-Consecutive Numbers!");

            //Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Enter numbers separated by a hyphen.\n");

            List<string> list = new List<string>();


            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                userInput.Split("-");
            }

            

            Console.WriteLine(userInput);


        }
    }
}
