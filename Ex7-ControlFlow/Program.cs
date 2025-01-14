using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace Ex7_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial!\n");

            //Excercise - 7:
            //Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.


            Console.WriteLine("\nEnter the number to comupte its Fatorial!\n");

            int userInput = Int32.Parse(Console.ReadLine());

            int initialNum = userInput;
            int userSum = 1;

            for (int i = userInput; i >= 1 ; i--)
            {
                userSum = userSum * i;
            }
                Console.WriteLine($"The {userInput}! is : {userSum}");
        }
    }
}
