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
            
            List<string> pascalCaseList = new List<string>();

            string userInput = Console.ReadLine();

            userInput = userInput.ToString().ToLower();

            string[] userString = userInput.Split(" ");

            string newWord;

            string wordSubstring;

            string concatWord;

            // Loop to Convert first of the word to Upper and concat the first letter to remaining substring of the word.
            foreach (string word in userString)
            {
                // First Character
                newWord = word.Substring(0,1).ToUpper();

                // Substring of the Word
                wordSubstring = word.Substring(1, word.Length-1);

                // Concating
                concatWord = newWord + wordSubstring;

                pascalCaseList.Add(concatWord);

            }

            Console.WriteLine(string.Join("", pascalCaseList));

        }
    }
}
