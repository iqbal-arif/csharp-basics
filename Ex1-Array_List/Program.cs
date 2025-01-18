using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace Ex1_Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fans Like Posting!");

            //Exercise - 1:
            //
            //When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
            //Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

            //  Storing UserName in the List
            var userNameList = new List<string>();

            //  Loop Exit condition;
            bool userEntry = true;

            do
            {
                Console.WriteLine("Enter User Name !!\n");

                var userName = Console.ReadLine();

                Console.WriteLine("Do you like my 'Facebook Post', Enter '1' for Like '0' for Dislike\n");

                string userLikeness = Console.ReadLine();

                if (string.IsNullOrEmpty(userName) || (string.IsNullOrEmpty(userLikeness)) && (userLikeness == "0"))
                {
                    userEntry = false;
                }
                else if(!string.IsNullOrEmpty(userName) && (userLikeness == "1"))
                {
                        userNameList.Add(userName);
                }
            }
            while (userEntry);

            //Displaying the Username that likes the POST.
            foreach (var userName in userNameList) 
            { 
                Console.WriteLine(userName);
            }
            //This code can be refactored and post likness can be prompted after adding the username in the list
        }
    }
}
