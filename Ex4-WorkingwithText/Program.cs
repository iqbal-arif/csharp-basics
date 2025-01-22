using System.ComponentModel;
using System.Linq;

namespace Ex4_WorkingwithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PascalCase Generator!\n");

            //4 - Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            List<char> pascalCaseList = new List<char>();

            string userInput = Console.ReadLine();

            userInput.Trim();


            foreach (char item in userInput)
            {
                //pascalCaseList.Add(item);

                

                Console.WriteLine(item);
            }

            //foreach (char item in pascalCaseList)
            //{
            //}
            //Console.WriteLine(String.Join(",",pascalCaseList));

            

            //Console.WriteLine(userInput);
        }
    }
}
