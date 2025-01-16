using System.ComponentModel;
using System.Threading.Tasks;
using System.Xml;

namespace Ex4_Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Storing, Displaying uniqe number and Exiting it!");

            //Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.
            
            bool loopExit = true;

            string userInput;

            List<int> userList = new List<int>();

            do
            {
                Console.WriteLine("Enter the Number : \n");

                userInput = Console.ReadLine();

                if ((!string.IsNullOrEmpty(userInput)) && (userInput.ToLower() != "quit"))
                {
                    userList.Add(int.Parse(userInput));
                }
                else if(userInput.ToLower() == "quit")
                {
                    loopExit = false;   
                }
            }
            while (loopExit);

            List<int> uniqueList = new List<int>();

            foreach (int item in userList)
            {
                if (uniqueList.Contains(item))
                {
                    continue;
                }
                else
                {
                    uniqueList.Add(item);
                }
            }
                 Console.WriteLine(string.Join(",",uniqueList));
        }

    }
}
