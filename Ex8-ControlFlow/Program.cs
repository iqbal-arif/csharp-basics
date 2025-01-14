using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using System.Threading.Channels;
using System;

namespace Ex8_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Random Number!\n");

            //Excercise - 9
            //    Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            // Random Number Generator
            var random = new Random().Next(1, 11);
            Console.WriteLine($"The generator Random Number is {random}\n");

            // Four Guess Attempts
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Your {i} guess :\n");
                
                //User Guess the number
                var userGuess = Int32.Parse(Console.ReadLine());

                if (userGuess == random)
                {
                     Console.WriteLine("\nYou are the Boss, You Won !!!!!");
                     return;
                }
                else
                {
                    continue;
                }
            }
                    Console.WriteLine("\nSorry, You Lost !!!");

        }
    }
}
