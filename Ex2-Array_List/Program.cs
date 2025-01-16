using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Ex2_Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Name Array!\n");

            //Excercise - 2
            //Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.Display the reversed name on the console.

            
            string[] fullName = new string[2];

            Console.WriteLine("Enter your First Name !\n");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("\nEnter your Last Name !\n");
            string userLastName = Console.ReadLine();

            fullName.SetValue(userFirstName, 0);
            fullName.SetValue(userLastName, 1);

            Console.WriteLine("\nFullname Before Reverse Operation\n");

            // Listing Array without Index before Reverse Operation
            foreach (string name in fullName)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nFullname After Reverse Operation\n");

            // ARRAY Reverse Opeartion
            Array.Reverse(fullName);

            // Listing Reverse Array with Index
            for (int i = 0; i < fullName.Length; i++)
            {
                Console.WriteLine($"{i.ToString()} : {fullName.GetValue(i)}");
            }
        }
    }
}
