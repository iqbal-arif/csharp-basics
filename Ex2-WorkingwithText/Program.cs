using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System;

namespace Ex2_WorkingwithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hypenated Number with Duplication Checker!\n");

            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            List<int> userList = new List<int>();


            Console.WriteLine("Enter few Hyphenated Number and check for Duplication **\n");

            string userString = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userString)) 
            {
                string[] strSplit = userString.Split("-");

                for (int i = 0; i < strSplit.Length; i++)
                {
                    userList.Add(int.Parse(strSplit[i]));

                }
                    userList.Sort();

                for (int i = 0; i < userList.Count; i++)
                {
                    
                if ((userList[i+1] - userList[i]) == 0)
                    {
                        Console.WriteLine("\nThe number has Duplicates");
                        break;
                    }
                }
            } else {
                Console.WriteLine("\nProgram Exited !!\n Try Again.\n");
            }
            
        }
    }
}
