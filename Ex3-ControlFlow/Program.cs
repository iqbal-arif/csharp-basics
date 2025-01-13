using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace Ex3_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Image Layout Analyzer!\n\n");

            //Exercise 3
            //Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait

            Console.WriteLine("Enter the Width of an Image!");

            int width = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The Image width is {width}\n");

            Console.WriteLine("Enter the Height of an Image!");

            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The Image height is {height}\n");


            if (width > height)
            {
                Console.WriteLine("The Image layout is 'LANDSCAPE' !!!");
            }
            else
            {
                Console.WriteLine("The Image layou is 'Portrait' !!");
            }
        }
    }
}
