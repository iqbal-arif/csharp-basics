using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace Ex1_WorkingwithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read File & Display Number of Words ! \n");

            //1 - Write a program that reads a text file and displays the number of words.

            var path = @"C:\Source\csharp-basics\Ex1-WorkingwithFiles\ex1.readword.txt";
            var content = File.ReadAllText(path) ;
            //Console.WriteLine(content) ;

            string[] fileContent = content.Split(" ");

            foreach (string file in fileContent)
            {
                Console.WriteLine(file);
            }


            int count = 0;

            foreach (string word in fileContent)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    count++;
                }
            }
            Console.WriteLine($"\nThe total number of words in this file is : {count} !!");
        }
    }
}
