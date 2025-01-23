using System.ComponentModel;

namespace Ex2_WorkingwithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displays Longest Word in file!\n");

            //2 - Write a program that reads a text file and displays the longest word in the file.

            var path = @"C:\Source\csharp-basics\Ex1-WorkingwithFiles\ex1.readword.txt";

            var fileContent = File.ReadAllText(path);

            //Console.WriteLine(fileContent);

            string[] wordList = fileContent.Replace("\r", "").Replace("\n", " ").Split(" ");

            // Setting the length of the Longest WpORD LENGHT
            int longestWordLength = 0;

            // Variable to set Long Word
            string longWord = " ";

            foreach (string word in wordList)
            {
                // Setting the Word length after looping words in the wordList
                int wordLength = word.Length;

                if (wordLength > longestWordLength)
                {
                    longestWordLength = word.Length;
                    longWord = word;
                }

            }


            Console.WriteLine($"\nThe longest word is : {longWord}");
        }
    }
}
