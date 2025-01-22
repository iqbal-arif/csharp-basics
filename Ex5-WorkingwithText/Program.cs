using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System;
using System.Linq.Expressions;
namespace Ex5_WorkingwithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vowel Counter!\n");

            //Write a program and ask the user to enter an English word. Count the number of vowels(a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

            Console.WriteLine("Enter an English Word !\n");

            string wordString = Console.ReadLine().ToLower();

            //# ToCharArray() Method
            char[] alphabetArray = wordString.ToCharArray();


            //# LINQ Method
            char[] letterArray = wordString.Select(c => c).ToArray();

            int counter = 0;

            
            //  Check the vowel and count it
            for (int i = 0; i < alphabetArray.Length; i++)
            {
                char switchCondtion = alphabetArray[i];

                if (switchCondtion.Equals('a') 
                    || switchCondtion.Equals('e') 
                    || switchCondtion.Equals('i') 
                    || switchCondtion.Equals('o') 
                    || switchCondtion.Equals('u'))
                {
                    Console.WriteLine($"Found It : {switchCondtion}\n");
                    counter++;
                    continue;
                }
            }
            
            Console.WriteLine($"The total number of vowel is :  {counter}");

        }

    }

}
