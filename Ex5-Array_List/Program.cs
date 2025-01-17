using System.ComponentModel;

namespace Ex5_Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Three Smallest Numbers!\n");

            //Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

            Console.WriteLine("Enter the list of comma separate numbers (e.g 5, 1, 9, 2, 10) \n");

            List<int> userList = new List<int>();

            int userNumber;

            string userInput = Console.ReadLine();

            var listSplit = userInput.Split(",");

        
            // Checking the total number of strings and running the loop until requirement is met 
            if (listSplit.Length <= 4 || string.IsNullOrEmpty(userInput))
            {

                listSplit.Append(userInput);

                do
                {
                    Console.WriteLine("\nInvalid List. Need at least 5 numbers or more");
                    Console.WriteLine("Try Again Please.\nEnter five or more numbers to meet the requirement.\n");
                    userInput = Console.ReadLine();

                    listSplit = userInput.Split(","); 
                    

                } while ((listSplit.Length <= 4) ) ;
                
            }

            // Converting String to Number and Adding to userList
            foreach (var item in listSplit)
            {
                userNumber = Convert.ToInt32(item);
                userList.Add(userNumber);
            }
             
            // Sorting to get list in asending order
            userList.Sort();

                
            // Displaying first 3 Items in the list.
            Console.WriteLine($"\nThe Three Smallest numbers in the list are :{userList[0]}, {userList[1]}, {userList[2]}");
        }
    }
}
