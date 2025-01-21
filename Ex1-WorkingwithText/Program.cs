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

            List<int> list = new List<int>();

            string userString = Console.ReadLine();
            string[] str = userString.Split("-");

            foreach (string item in str)
            {
                list.Add(int.Parse(item));

            }
            //list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i + 1] - list[i] == 1)
                {
                    Console.WriteLine("\nConsecutive Number !");
                    break;
                }
                else
                {
                    Console.WriteLine("\nNot a Consecutive Number !");
                    break;
                }
            }

        }
        
    }
}
