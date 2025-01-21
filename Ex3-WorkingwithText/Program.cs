using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Ex3_WorkingwithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("24 Hour Time Validation!\n");

            //3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00). A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, display "Invalid Time".If the user doesn't provide any values, consider it as invalid time.

            Console.WriteLine("Enter time in 24-hour time format '19:00'\n");

            // User Time Input
            string userTime = Console.ReadLine();
            Console.WriteLine(userTime);

            // Declaring Variable
            DateTime dDate;

            // Setting Time Format
            string[] formats = {"HH:mm"};


            if (DateTime.TryParseExact(userTime, formats,
                                new CultureInfo("en-US"),
                                DateTimeStyles.None,
                                out dDate))
            {
                Console.WriteLine("Valid\n");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
